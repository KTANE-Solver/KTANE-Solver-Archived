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
    public partial class ConnectionCheckForm : ModuleForm
    {
        public ConnectionCheckForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm) : base(bomb, logFileWriter, moduleSelectionForm, "Connection Check", false)
        {
            InitializeComponent();
        }

        private void UpdateForm()
        {
            topLeftTextBox.Text = "";
            topRightTextBox.Text = "";
            bottomLeftTextBox.Text = "";
            bottomRightTextBox.Text = "";

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
            string topLeft = topLeftTextBox.Text;
            string topRight = topRightTextBox.Text;
            string bottomLeft = bottomLeftTextBox.Text;
            string bottomRight = bottomRightTextBox.Text;

            if (topLeft.Length != 2 || topRight.Length != 2 || bottomLeft.Length != 2 || bottomRight.Length != 2)
            {
                ShowErrorMessage("Text boxes can only have 2 numbers");
                return;
            }

            int [] topLeftArr;
            int[] topRightArr;
            int[] bottomLeftArr;
            int[] bottomRightArr;

            if (topLeft[0] == topLeft[1] || topRight[0] == topRight[1] || bottomLeft[0] == bottomLeft[1] || bottomRight[0] == bottomRight[1])
            {
                ShowErrorMessage("Numbers in the same text box can't be the same");
                return;
            }

            try
            {
                topLeftArr =  new int[] { int.Parse("" + topLeft[0]), int.Parse("" + topLeft[1]) };
                topRightArr = new int[] { int.Parse("" + topRight[0]), int.Parse("" + topRight[1]) };
                bottomLeftArr = new int[] { int.Parse("" + bottomLeft[0]), int.Parse("" + bottomLeft[1]) };
                bottomRightArr = new int[] { int.Parse("" + bottomRight[0]), int.Parse("" + bottomRight[1]) };

            }

            catch
            {
                ShowErrorMessage("Text boxes can only have 2 numbers");
                return;
            }

            ConnectionCheck module = new ConnectionCheck(topLeftArr, topRightArr, bottomLeftArr, bottomRightArr, Bomb, LogFileWriter);
            module.Solve();
            UpdateForm();
        }
    }
}
