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
    public partial class LetteredKeysForm : ModuleForm
    {
        public LetteredKeysForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int num;

            try
            {
                num = int.Parse(textBox1.Text);
            }

            catch
            {
                ShowErrorMessage("Textbox can only contain a number between 0 and 99");
                return;
            }

            if (num < 0 || num > 99)
            {
                ShowErrorMessage("Textbox can only contain a number between 0 and 99");
                return;
            }

            LetteredKeys module = new LetteredKeys(Bomb, LogFileWriter, num);
            module.Solve();

            textBox1.Text = "";
        }

        private void stikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }
    }
}
