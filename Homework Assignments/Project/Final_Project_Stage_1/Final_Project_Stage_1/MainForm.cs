using System;
using System.Windows.Forms;

namespace Final_Project_Stage_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void OnAction0Button_Click(object sender, EventArgs e)
        {
            combatLogTextBox.Text = $"entry: action 1...\r\n{combatLogTextBox.Text}";
        }

        void OnAction1Button_Click(object sender, EventArgs e)
        {
            combatLogTextBox.Text = $"entry: action 2!!\r\n{combatLogTextBox.Text}";
        }

        void OnAction2Button_Click(object sender, EventArgs e)
        {
            combatLogTextBox.Text = $"entry: action 3!\r\n{combatLogTextBox.Text}";
        }

        void OnCombatLogTextBox_TextChanged(object sender, EventArgs e)
        {
            combatLogTextBox.ScrollToCaret();
        }
    }
}
