using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace KTANE_Solver
{
    public partial class AdventureGameStatForm : ModuleForm
    {
        AdventureGameItemForm itemForm;
        string weapon1, weapon2, weapon3;
        AdventureGame.Item item1, item2, item3, item4, item5;
        string enemy;
        public AdventureGameStatForm(string weapon1, string weapon2, string weapon3, AdventureGame.Item item1, AdventureGame.Item item2, AdventureGame.Item item3,
               AdventureGame.Item item4, AdventureGame.Item item5, string enemy, Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm, AdventureGameItemForm itemForm)
        {
            InitializeComponent();

            this.weapon1 = weapon1;
            this.weapon2 = weapon2;
            this.weapon3 = weapon3;

            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;

            this.itemForm = itemForm;

            this.enemy = enemy;

            UpdateForm(bomb, logFileWriter, moduleSelectionForm);

        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            strengthTextBox.Text = "";
            intelligenceTextBox.Text = "";
            dexterityTextBox.Text = "";
            heightTextBox.Text = "";
            temperatureTextBox.Text = "";
            gravityTextBox.Text = "";
            pressureTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemForm.Show();
        }

        private void moduleSelectionButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int strength;
            int itnelligence;
            int dexterity;
            int height;
            int temp;
            double gravity;
            int pressure;

            try
            {
                strength = int.Parse(strengthTextBox.Text);
                itnelligence = int.Parse(intelligenceTextBox.Text);
                dexterity = int.Parse(dexterityTextBox.Text);
                height = int.Parse(heightTextBox.Text);
                temp = int.Parse(temperatureTextBox.Text);
                gravity = double.Parse(gravityTextBox.Text);
                pressure = int.Parse(pressureTextBox.Text);
            }

            catch
            {
                ShowErrorMessage("Only numbers can go in these text box", "Adventure game Error");
                return;
            }

            new AdventureGame(strength, dexterity, itnelligence, height, temp, gravity, pressure, 
                              weapon1, weapon2, weapon3, item1, item2, item3, item4, item5, enemy, 
                              Bomb, LogFileWriter);

            this.Hide();
            itemForm.UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
            itemForm.Show();
        }
    }
}
