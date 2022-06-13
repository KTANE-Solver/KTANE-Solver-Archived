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
    public partial class CreationOtherStageForm : ModuleForm
    {
        private Creation module;
        private CreationForm stage1Form;
        private int stage;

        public CreationOtherStageForm(Bomb bomb, StreamWriter logFileWriter, Creation module, CreationForm stage1Form, ModuleSelectionForm moduleSelectionForm) : base(bomb, logFileWriter, moduleSelectionForm, "Creation", false)
        { 
            InitializeComponent();
            this.module = module;
            this.stage1Form = stage1Form;
            UpdateForm(2);
        }

        public void UpdateForm(int stage)
        {
            this.stage = stage;

            String[] weather = new string[] { "Rain", "Wind", "Heat Wave", "Meteor Shower" };

            weatherComboBox.Items.Clear();
            weatherComboBox.Items.AddRange(weather);
            weatherComboBox.Text = weather[0];
            weatherComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Creation.Weather weather = (Creation.Weather)Enum.Parse(typeof(Creation.Weather), weatherComboBox.Text.Trim());
            module.Solve(weather, stage - 1);

            if (module.DirectionCount == stage)
            {
                this.Hide();
                stage1Form.UpdateForm();
                stage1Form.Show();
            }

            else
            {
                UpdateForm(stage + 1);
            }
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                this.Hide();
                stage1Form.UpdateForm();
                stage1Form.Show();
            }

            else
            {
                UpdateForm(stage - 1);
            }
        }

        private void moduleSelectionButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }
    }
}
