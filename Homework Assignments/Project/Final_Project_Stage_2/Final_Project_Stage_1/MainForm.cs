using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Final_Project_Classes;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Final_Project_Stage_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region FormLevelFieldsAndProperties

        Random rng = new Random();
        List<CheckBox> heroCheckBoxes = new List<CheckBox>();
        List<CheckBox> enemyCheckBoxes = new List<CheckBox>();
        List<Label> heroesLabels = new List<Label>();
        List<Label> enemyLabels = new List<Label>();
        List<Character> heroes = new List<Character>();
        List<Character> enemies = new List<Character>();
        LinkedList<Character> turnOrder;
        Dictionary<CharacterType, Image> images = new Dictionary<CharacterType, Image>();
        bool isSpecialAction;
        GameState currentGameState;

        public Character CurrentCharacter => turnOrder.First.Value;

        #endregion

        #region EventMethods

        void OnMainForm_Load(object sender, EventArgs e)
        {
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
                enemyLabels[i].Text = enemies[i].Type.ToString();
            }

            // Build the turn order
            turnOrder = new LinkedList<Character>(heroes.Concat(enemies).OrderByDescending(character => character.Speed));

            // Flush the labels
            UpdateHeroStatus();

            // Start the FSM
            ChangeState(enemies.Contains(CurrentCharacter) ? GameState.EnemyChoosingAction : GameState.HeroChoosingAction);
            ChangeState(GameState.HeroChoosingAction);
        }

        void OnAction0Button_Click(object sender, EventArgs e)
        {
            isSpecialAction = false;
            ChangeState(GameState.HeroChoosingTarget);
        }

        void OnAction1Button_Click(object sender, EventArgs e)
        {
            isSpecialAction = true;
            ChangeState(GameState.HeroChoosingTarget);
        }

        void OnCombatLogTextBox_TextChanged(object sender, EventArgs e)
        {
            combatLogTextBox.ScrollToCaret();
        }

        void OnHero0CheckChanged(object sender, EventArgs e)
        {
            ProcessHeroClick(0);
        }

        void OnHero1CheckChanged(object sender, EventArgs e)
        {
            ProcessHeroClick(1);
        }

        void OnHero2CheckChanged(object sender, EventArgs e)
        {
            ProcessHeroClick(2);
        }

        void OnEnemy0CheckChanged(object sender, EventArgs e)
        {
            ProcessEnemyClick(0);
        }

        void OnEnemy1CheckChanged(object sender, EventArgs e)
        {
            ProcessEnemyClick(1);
        }

        void OnEnemy2CheckChanged(object sender, EventArgs e)
        {
            ProcessEnemyClick(2);
        }

        #endregion

        #region HelperMethods

        void ChangeState(GameState newState)
        {
            currentGameState = newState;

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
                        DealDamage(heroes[rng.Next(0, heroes.Count)]);
                    }

                    // Pass the turn
                    GoToTheNextCharacter();

                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
            }
        }

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

        Character CreateCharacter(CharacterType type)
        {
            switch (type)
            {
                case CharacterType.Knight:
                    return new Character(type, strength: 35, intelligence: 5, physicalDefenseValue: 15, magicalDefenseValue: 7, hitPoints: 100, skillPoints: 0, speed: 11);
                case CharacterType.Wizard:
                    return new Character(type, strength: 0, intelligence: 30, physicalDefenseValue: 8, magicalDefenseValue: 16, hitPoints: 80, skillPoints: 0, speed: 12);
                case CharacterType.Cleric:
                    return new Character(type, strength: 20, intelligence: 25, physicalDefenseValue: 12, magicalDefenseValue: 12, hitPoints: 75, skillPoints: 10, speed: 9);
                case CharacterType.Bandito:
                    return new Character(type, strength: 25, intelligence: 0, physicalDefenseValue: 7, magicalDefenseValue: 7, hitPoints: 40, skillPoints: 0, speed: 10);
                case CharacterType.Ogre:
                    return new Character(type, strength: 27, intelligence: 0, physicalDefenseValue: 15, magicalDefenseValue: 7, hitPoints: 50, skillPoints: 0, speed: 8);
                case CharacterType.Dragon:
                    return new Character(type, strength: 18, intelligence: 31, physicalDefenseValue: 14, magicalDefenseValue: 14, hitPoints: 60, skillPoints: 0, speed: 7);
                case CharacterType.Cat:
                    return new Character(type, strength: 0, intelligence: 33, physicalDefenseValue: 12, magicalDefenseValue: 12, hitPoints: 80, skillPoints: 0, speed: 13);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        void GoToTheNextCharacter()
        {
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

        void DealDamage(params Character[] targets)
        {
            foreach (Character target in targets)
            {
                int damage = CurrentCharacter.IsPhysical || isSpecialAction ? CurrentCharacter.Strength - target.PhysicalDefenseValue
                    : CurrentCharacter.Intelligence - target.MagicalDefenseValue;

                if (damage > 0)
                {
                    target.HitPoints -= damage;
                    AddTextToCombatLog($"{CurrentCharacter.Type} deals {damage} damage to {target.Type}");

                    if (target.HitPoints <= 0)
                    {
                        AddTextToCombatLog($"{target.Type} DIED!!!");
                        turnOrder.Remove(target);
                    }
                }
            }

            UpdateHeroStatus();

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
        }

        void UpdateHeroStatus()
        {
            for (int i = 0; i < heroes.Count; i++)
            {
                heroesLabels[i].Text = $"{heroes[i].Type}\nHP: {heroes[i].HitPoints}\nSP: {heroes[i].SkillPoints}";
            }
        }

        void AddTextToCombatLog(string message)
        {
            combatLogTextBox.Text = $"{message}\r\n{combatLogTextBox.Text}";
        }

        void ProcessHeroClick(int index)
        {
            if (currentGameState == GameState.HeroChoosingTarget)
            {
                heroes[index].HitPoints += CurrentCharacter.Intelligence;
                AddTextToCombatLog($"Cleric healed {heroes[index].Type} for {CurrentCharacter.Intelligence}");
                GoToTheNextCharacter();
            }
        }

        void ProcessEnemyClick(int index)
        {
            if (currentGameState == GameState.HeroChoosingTarget)
            {
                AddTextToCombatLog("------------------------------");
                DealDamage(enemies[index]);
                GoToTheNextCharacter();
            }
        }

        #endregion
    }
}
