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
    public partial class BrokenButtonsForm : ModuleForm
    {
        public BrokenButtonsForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm) : base(bomb, logFileWriter, moduleSelectionForm, "Broken Buttons", false)
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            BrokenButtons module = new BrokenButtons(Bomb, LogFileWriter);

            List<string> buttonList = module.buttonPressed;


            while (buttonList.Count != 5)
            {
                PrintDebugLine("" + buttonList.Count);

                module.FindButtonToPress();

                if (module.buttonPressed.Contains("DON'T PRESS"))
                {
                    break;
                }
            }

            module.Solve();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }
    }
}
