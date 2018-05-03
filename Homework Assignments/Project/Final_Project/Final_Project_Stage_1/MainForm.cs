using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Final_Project_Classes;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using CS3020HW3Classes;

namespace Final_Project_Stage_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region FormLevelFieldsAndProperties

        const string StatsPath = "Data/stats.bin";

        readonly Random rng = new Random();
        readonly Dictionary<CharacterType, Image> images = new Dictionary<CharacterType, Image>();
        readonly List<CheckBox> heroCheckBoxes = new List<CheckBox>();
        readonly List<CheckBox> enemyCheckBoxes = new List<CheckBox>();
        readonly List<Label> heroesLabels = new List<Label>();
        readonly List<Label> enemyLabels = new List<Label>();
        readonly List<Character> heroes = new List<Character>();
        List<Character> enemies = new List<Character>();
        LinkedList<Character> turnOrder;
        GameState currentGameState;
        bool gameIsOver;
        bool isSpecialAction;
        int roundCount = 1;

        public Stats LifetimeStats { get; private set; }

        public Character CurrentCharacter => turnOrder.First.Value;

        #endregion

        #region EventMethods

        void OnMainForm_Load(object sender, EventArgs e)
        {
            // Load up lifetime stats
            if (File.Exists(StatsPath))
            {
                LifetimeStats = Util.DeserializeIn(LifetimeStats, StatsPath);
            }
            else
            {
                Directory.CreateDirectory("Data");
                LifetimeStats = new Stats();
                Util.SerializeOut(LifetimeStats, StatsPath);
            }

            // Load up the images
            ComponentResourceManager resources = new ComponentResourceManager(GetType());
            images.Add(CharacterType.Bandito, (Image)resources.GetObject("enemy2CheckBox.Image"));
            images.Add(CharacterType.Ogre, (Image)resources.GetObject("enemy1CheckBox.Image"));
            images.Add(CharacterType.Dragon, (Image)resources.GetObject("enemy0CheckBox.Image"));

            // Create the hero objects
            heroes.Add(CreateCharacter(CharacterType.Knight));
            heroes.Add(CreateCharacter(CharacterType.Wizard));
            heroes.Add(CreateCharacter(CharacterType.Cleric));

            // Create random enemy objects
            enemies.Add(CreateCharacter((CharacterType)rng.Next(3, 6)));
            enemies.Add(CreateCharacter((CharacterType)rng.Next(3, 6)));
            enemies.Add(CreateCharacter((CharacterType)rng.Next(3, 6)));

            // Store the labels
            heroesLabels.Add(hero0StatusLabel);
            heroesLabels.Add(hero1StatusLabel);
            heroesLabels.Add(hero2StatusLabel);
            enemyLabels.Add(villan0StatusLabel);
            enemyLabels.Add(villan1StatusLabel);
            enemyLabels.Add(villan2StatusLabel);

            // Fill the list of check boxes
            heroCheckBoxes.Add(hero0CheckBox);
            heroCheckBoxes.Add(hero1CheckBox);
            heroCheckBoxes.Add(hero2CheckBox);
            enemyCheckBoxes.Add(enemy0CheckBox);
            enemyCheckBoxes.Add(enemy1CheckBox);
            enemyCheckBoxes.Add(enemy2CheckBox);

            // Fill in the enemy images
            for (int i = 0; i < enemies.Count; i++)
            {
                enemyCheckBoxes[i].Image = images[enemies[i].Type];
            }

            // Build the turn order
            turnOrder = new LinkedList<Character>(heroes.Concat(enemies).OrderByDescending(character => character.Speed));

            // Flush the labels
            UpdateStatsLabels();

            // Start the FSM
            ChangeState(enemies.Contains(CurrentCharacter) ? GameState.EnemyChoosingAction : GameState.HeroChoosingAction);
        }

        void OnAction0Button_Click(object sender, EventArgs e)
        {
            isSpecialAction = false;
            ChangeState(GameState.HeroChoosingTarget);
            gameMessageLabel.Select();
        }

        void OnAction1Button_Click(object sender, EventArgs e)
        {
            isSpecialAction = true;
            ChangeState(GameState.HeroChoosingTarget);
            gameMessageLabel.Select();
        }

        void OnCombatLogTextBox_TextChanged(object sender, EventArgs e)
        {
            combatLogTextBox.ScrollToCaret();
            gameMessageLabel.Select();
            UpdateStatsLabels();
        }

        void OnHero0CheckChanged(object sender, EventArgs e)
        {
            ProcessHeroClick(0);
            gameMessageLabel.Select();
            UpdateStatsLabels();
        }

        void OnHero1CheckChanged(object sender, EventArgs e)
        {
            ProcessHeroClick(1);
            gameMessageLabel.Select();
            UpdateStatsLabels();
        }

        void OnHero2CheckChanged(object sender, EventArgs e)
        {
            ProcessHeroClick(2);
            gameMessageLabel.Select();
            UpdateStatsLabels();
        }

        void OnEnemy0CheckChanged(object sender, EventArgs e)
        {
            ProcessEnemyClick(0);
            gameMessageLabel.Select();
            UpdateStatsLabels();
        }

        void OnEnemy1CheckChanged(object sender, EventArgs e)
        {
            ProcessEnemyClick(1);
            gameMessageLabel.Select();
            UpdateStatsLabels();
        }

        void OnEnemy2CheckChanged(object sender, EventArgs e)
        {
            ProcessEnemyClick(2);
            gameMessageLabel.Select();
            UpdateStatsLabels();
        }

        void OnAboutGameButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm(this);
            aboutForm.ShowDialog();
        }

        #endregion

        #region HelperMethods

        /// <summary>
        /// Changes the state of the game.
        /// </summary>
        /// <param name="newState">The given state to be moved to.</param>
        void ChangeState(GameState newState)
        {
            currentGameState = newState;

            if (gameIsOver)
            {
                return;
            }

            switch (newState)
            {
                case GameState.HeroChoosingAction:
                    // Configure button states
                    ConfigureButtonState(true, CurrentCharacter.Type == CharacterType.Cleric, false, false);

                    UpdateBanner($"Choose an action for \"{CurrentCharacter.Type}\"");

                    break;

                case GameState.HeroChoosingTarget:
                    // Configure button state for cleric special
                    ConfigureButtonState(false, false, isSpecialAction, !isSpecialAction);

                    UpdateBanner(isSpecialAction ? $"Choose a team mate for \"{CurrentCharacter.Type}\" to heal" : $"Choose an enemy for \"{CurrentCharacter.Type}\" to hit");

                    break;

                case GameState.EnemyChoosingAction:
                    // Configure button states
                    ConfigureButtonState(false, false, false, false);

                    UpdateBanner($"Currently \"{CurrentCharacter.Type}\"'s turn");

                    // Choose the action
                    isSpecialAction = false;
                    if (CurrentCharacter.Type == CharacterType.Dragon)
                    {
                        isSpecialAction = rng.Next(0, 2) == 0;
                    }

                    // Choose the target(s)
                    if (isSpecialAction)
                    {
                        DealDamage(heroes.ToArray());
                    }
                    else
                    {
                        bool hasChosenValidTarget = false;
                        Character target = null;
                        while (!hasChosenValidTarget)
                        {
                            target = heroes[rng.Next(0, heroes.Count)];

                            if (target.HitPoints > 0)
                            {
                                hasChosenValidTarget = true;
                            }
                        }

                        DealDamage(target);
                    }

                    // Pass the turn
                    GoToTheNextCharacter();

                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
            }
        }

        /// <summary>
        /// Configures the clickable state of the boxes and buttons in the game.
        /// </summary>
        /// <param name="action0">If the "Action 1" button can be clicked.</param>
        /// <param name="action1">If the "Action 2" button can be clicked.</param>
        /// <param name="heroesOn">If the heroes can be clicked.</param>
        /// <param name="enemiesOn">If the heroes can be clicked.</param>
        void ConfigureButtonState(bool action0, bool action1, bool heroesOn, bool enemiesOn)
        {
            // Set the buttons state
            action0Button.Enabled = action0;
            action1Button.Enabled = action1;
            for (int i = 0; i < heroCheckBoxes.Count; i++)
            {
                heroCheckBoxes[i].AutoCheck = heroesOn;
                enemyCheckBoxes[i].AutoCheck = enemiesOn;
            }

            // Set text of action1Button
            action1Button.Text = action1 ? "Heal Team Mate" : string.Empty;
        }

        /// <summary>
        /// Updates the main game banner.
        /// </summary>
        /// <param name="message">The message to be displayed in the main game banner.</param>
        void UpdateBanner(string message)
        {
            // Constants and locals
            const int Limit = 15;
            StringBuilder sb = new StringBuilder();
            int counter = 0;

            // Print with breaks
            foreach (char c in message)
            {
                sb.Append(c);
                if (counter == Limit)
                {
                    sb.Append("\n");
                    counter = 0;
                }
                counter++;
            }

            // Print the banner
            gameMessageLabel.Text = sb.ToString();
        }

        /// <summary>
        /// Returns a fully built character based on the passed in type.
        /// </summary>
        /// <param name="type">The CharacterType of the character that needs building.</param>
        Character CreateCharacter(CharacterType type)
        {
            switch (type)
            {
                case CharacterType.Knight:
                    // ReSharper disable ArgumentsStyleLiteral
                    return new Character(type, strength: 35, intelligence: 5, physicalDefenseValue: 15, magicalDefenseValue: 7, hitPoints: 100, skillPoints: 0, speed: 11);
                case CharacterType.Wizard:
                    return new Character(type, strength: 0, intelligence: 30, physicalDefenseValue: 8, magicalDefenseValue: 16, hitPoints: 75, skillPoints: 0, speed: 12);
                case CharacterType.Cleric:
                    return new Character(type, strength: 20, intelligence: 25, physicalDefenseValue: 12, magicalDefenseValue: 12, hitPoints: 80, skillPoints: 10, speed: 9);
                case CharacterType.Bandito:
                    return new Character(type, strength: 25, intelligence: 0, physicalDefenseValue: 7, magicalDefenseValue: 7, hitPoints: 40, skillPoints: 0, speed: 10);
                case CharacterType.Ogre:
                    return new Character(type, strength: 27, intelligence: 0, physicalDefenseValue: 15, magicalDefenseValue: 7, hitPoints: 50, skillPoints: 0, speed: 8);
                case CharacterType.Dragon:
                    return new Character(type, strength: 18, intelligence: 31, physicalDefenseValue: 14, magicalDefenseValue: 14, hitPoints: 60, skillPoints: 0, speed: 7);
                case CharacterType.Cat:
                    return new Character(type, strength: 0, intelligence: 33, physicalDefenseValue: 12, magicalDefenseValue: 12, hitPoints: 80, skillPoints: 0, speed: 13);
                // ReSharper restore ArgumentsStyleLiteral
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        /// <summary>
        /// Transfers the current character to the next one in the turn oder.
        /// </summary>
        void GoToTheNextCharacter()
        {
            // Update the current character
            Character tmp = CurrentCharacter;
            turnOrder.RemoveFirst();
            turnOrder.AddLast(tmp);

            // Change the state
            ChangeState(enemies.Contains(CurrentCharacter) ? GameState.EnemyChoosingAction : GameState.HeroChoosingAction);

            // Uncheck everyone
            for (int i = 0; i < heroes.Count; i++)
            {
                heroCheckBoxes[i].Checked = CurrentCharacter == heroes[i];
                enemyCheckBoxes[i].Checked = CurrentCharacter == enemies[i];
            }
        }

        /// <summary>
        /// Deals damage to target(s), then processes logic of aftermath.
        /// </summary>
        /// <param name="targets">The target(s) to be dealt the damage.</param>
        void DealDamage(params Character[] targets)
        {
            foreach (Character target in targets)
            {
                // Calculate damage
                int damage = CurrentCharacter.IsPhysical || isSpecialAction ? CurrentCharacter.Strength - target.PhysicalDefenseValue
                    : CurrentCharacter.Intelligence - target.MagicalDefenseValue;

                // Apply the damage if it's greater than 0
                if (damage > 0)
                {
                    string buffer = CurrentCharacter.Type >= CharacterType.Bandito ? "  ***  " : string.Empty;
                    target.HitPoints -= damage;

                    AddTextToCombatLog($"{buffer}{CurrentCharacter.Type} deals {damage} damage to {target.Type}{buffer}");

                    if (target.HitPoints == 0)
                    {
                        AddTextToCombatLog($"{target.Type} DIED!!!");
                        turnOrder.Remove(target);
                    }
                }
            }

            // Update display
            UpdateStatsLabels();

            // If a hero or an enemy dies, disable their box
            for (int i = 0; i < heroes.Count; i++)
            {
                if (heroes[i].HitPoints <= 0)
                {
                    heroCheckBoxes[i].Enabled = false;
                }
                if (enemies[i].HitPoints <= 0)
                {
                    enemyCheckBoxes[i].Enabled = false;
                }
            }

            // If all enemies are dead, respawn new ones
            bool allEnemiesDead = true;
            foreach (Character character in enemies)
            {
                if (character.HitPoints > 0)
                {
                    allEnemiesDead = false;
                }
            }

            if (allEnemiesDead)
            {
                // Incremend the round and update the label
                roundCount++;
                roundCountLabel.Text = $"Round: {roundCount}";
                AddTextToCombatLog("=======================================");
                AddTextToCombatLog($"All enemies defeated... ROUND {roundCount}!!!");
                AddTextToCombatLog("=======================================");
                ResetEnemies();
            }

            // If all heroes are dead, display game over message
            bool allHeroesDead = true;
            foreach (Character character in heroes)
            {
                if (character.HitPoints > 0)
                {
                    allHeroesDead = false;
                }
            }

            if (allHeroesDead)
            {
                gameIsOver = true;

                // Score the game
                if (roundCount > LifetimeStats.MostRoundsAchieved)
                {
                    LifetimeStats.MostRoundsAchieved = roundCount;
                    Util.SerializeOut(LifetimeStats, StatsPath);
                }

                DialogResult dialog = MessageBox.Show("Would you like to play again?","Game Over", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    Close();
                }
            }
        }

        /// <summary>
        /// Updates the character's status bars based on their internal stats.
        /// </summary>
        void UpdateStatsLabels()
        {
            for (int i = 0; i < heroes.Count; i++)
            {
                heroesLabels[i].Text = $"{heroes[i].Type}\nHP: {heroes[i].HitPoints}\nSP: {heroes[i].SkillPoints}";
                enemyLabels[i].Text = $"{enemies[i].Type}\nHP: {enemies[i].HitPoints}";
            }
        }

        /// <summary>
        /// Adds text to the combat log.
        /// </summary>
        /// <param name="message">The string to be added to the combat log.</param>
        void AddTextToCombatLog(string message)
        {
            combatLogTextBox.Text = $"{message}\r\n{combatLogTextBox.Text}";
        }

        /// <summary>
        /// Processes the choice of the player.
        /// </summary>
        /// <param name="index">The index of the chosen enemy or hero.</param>
        void ProcessHeroClick(int index)
        {
            if (currentGameState == GameState.HeroChoosingTarget)
            {
                heroes[index].HitPoints += CurrentCharacter.Intelligence;
                AddTextToCombatLog($"Cleric healed {heroes[index].Type} for {CurrentCharacter.Intelligence}");
                GoToTheNextCharacter();
            }
        }

        /// <summary>
        /// Processes the enemy's target choice.
        /// </summary>
        /// <param name="index">The index of the targetet hero.</param>
        void ProcessEnemyClick(int index)
        {
            if (currentGameState == GameState.HeroChoosingTarget)
            {
                DealDamage(enemies[index]);
                GoToTheNextCharacter();
            }
        }

        void ResetGame()
        {
            // Reset stats and things
            gameIsOver = false;
            roundCount = 1;

            // Rebuild the heroes and enemies
            for (int i = 0; i < heroes.Count; i++)
            {
                heroes[i] = CreateCharacter(heroes[i].Type);
                heroCheckBoxes[i].Enabled = true;
            }
            ResetEnemies();

            // Flush the combat log
            combatLogTextBox.Text = string.Empty;

            // Start the FSM
            ChangeState(enemies.Contains(CurrentCharacter) ? GameState.EnemyChoosingAction : GameState.HeroChoosingAction);
        }

        /// <summary>
        /// Reset yon enemies.
        /// </summary>
        void ResetEnemies()
        {
            // Flush and recreate enemies
            enemies = new List<Character>
            {
                CreateCharacter((CharacterType)rng.Next(3, 6)),
                CreateCharacter((CharacterType)rng.Next(3, 6)),
                CreateCharacter((CharacterType)rng.Next(3, 6))
            };

            // Fill in the enemy images
            for (int i = 0; i < enemies.Count; i++)
            {
                enemyCheckBoxes[i].Enabled = true;
                enemyCheckBoxes[i].Image = images[enemies[i].Type];
            }

            // Rebuild the turn order
            turnOrder = new LinkedList<Character>(heroes.Where(hero => hero.HitPoints != 0).Concat(enemies).OrderByDescending(character => character.Speed));
            UpdateStatsLabels();
        }

        #endregion
    }
}