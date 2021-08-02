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
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            RockPaperScissorsLizardSpock.Symbol symbol;

            if (decoyComboBox.Text == "")
            {
                symbol = (RockPaperScissorsLizardSpock.Symbol)Enum.Parse(typeof(RockPaperScissorsLizardSpock.Symbol), decoyComboBox.Text);
            }

            else
            {
                symbol = RockPaperScissorsLizardSpock.Symbol.Null;
            }



            new RockPaperScissorsLizardSpock(symbol, Bomb, LogFileWriter);

            UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
        }
    }
}
