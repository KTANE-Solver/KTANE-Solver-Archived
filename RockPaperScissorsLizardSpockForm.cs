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
    public partial class RockPaperScissorsLizardSpockForm : ModuleForm
    {
        public RockPaperScissorsLizardSpockForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            String[] symbols = new String[] { "", "Lizard", "Paper", "Rock", "Scissors", "Spock"};

            decoyComboBox.Items.Clear();
            decoyComboBox.Items.AddRange(symbols);
            decoyComboBox.Text = symbols[0];
            decoyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike("Rock Paper Scissors Lizard Spock");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            RockPaperScissorsLizardSpock.Symbol symbol;

            if (decoyComboBox.Text == "")
            {
                symbol = RockPaperScissorsLizardSpock.Symbol.Null;
            }

            else
            {
                symbol = (RockPaperScissorsLizardSpock.Symbol)Enum.Parse(typeof(RockPaperScissorsLizardSpock.Symbol), decoyComboBox.Text);

            }



            RockPaperScissorsLizardSpock module = new RockPaperScissorsLizardSpock(symbol, Bomb, LogFileWriter);
            module.Solve();

            UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
        }
    }
}
