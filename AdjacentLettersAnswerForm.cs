using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTANE_Solver
{
    public partial class AdjacentLettersAnswerForm : Form
    {
        public AdjacentLettersAnswerForm(bool[,] answer)
        {
            InitializeComponent();

            row1Button1.BackColor = GetColor(answer[0, 0]);
            row1Button2.BackColor = GetColor(answer[0, 1]);
            row1Button3.BackColor = GetColor(answer[0, 2]);
            row1Button4.BackColor = GetColor(answer[0, 3]);

            row2Button1.BackColor = GetColor(answer[1, 0]);
            row2Button2.BackColor = GetColor(answer[1, 1]);
            row2Button3.BackColor = GetColor(answer[1, 2]);
            row2Button4.BackColor = GetColor(answer[1, 3]);

            row3Button1.BackColor = GetColor(answer[2, 0]);
            row3Button2.BackColor = GetColor(answer[2, 1]);
            row3Button3.BackColor = GetColor(answer[2, 2]);
            row3Button4.BackColor = GetColor(answer[2, 3]);
        }

        private Color GetColor(bool b)
        {
            if (b)
            {
                return Color.Green;
            }

            return Color.White;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
