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
    public partial class PokerStage2Form : ModuleForm
    {
        PokerStage1Form pokerStage1Form;
        public Poker module;

        public PokerStage2Form(PokerStage1Form pokerStage1Form, ModuleSelectionForm moduleSelectionForm, Poker module, Bomb bomb, StreamWriter logFileWriter)
        {
            InitializeComponent();
            UpdateForm(pokerStage1Form, moduleSelectionForm, module, bomb, logFileWriter);
        }

        public void UpdateForm(PokerStage1Form pokerStage1Form, ModuleSelectionForm moduleSelectionForm, Poker module, Bomb bomb, StreamWriter logFileWriter)
        {
            this.pokerStage1Form = pokerStage1Form;
            this.module = module;

            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            responseComboBox.Items.Clear();
            responseComboBox.Items.AddRange(new String [] { "Are you sure?", "Awful play!", "Really?", "Really, really?", "Sure about that?", "Terrible play!" });
            responseComboBox.Text = "Are you sure?";
            responseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void moduleSelectionButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            pokerStage1Form.UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
            pokerStage1Form.Show();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            module.response = responseComboBox.Text;

            System.Diagnostics.Debug.WriteLine($"Response: {module.response}\n");


            String answer = module.BluffTruth();

            MessageBox.Show($"Press {answer}", "Poker Part 2 Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            PokerStage3Form stage3 = new PokerStage3Form(pokerStage1Form, this, ModuleSelectionForm, module, Bomb, LogFileWriter);
            stage3.Show();
        }

        private void PokerStage2Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram(e);
        }
    }
}
