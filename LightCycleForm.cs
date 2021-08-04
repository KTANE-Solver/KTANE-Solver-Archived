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
    public partial class LightCycleForm : ModuleForm
    {
        public LightCycleForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            ColorComboBox(colorComboBox1);
            ColorComboBox(colorComboBox2);
            ColorComboBox(colorComboBox3);
            ColorComboBox(colorComboBox4);
            ColorComboBox(colorComboBox5);
        }

        private void ColorComboBox(ComboBox comboBox)
        {
            String[] colors = { "Blue", "Green", "Magenta", "Red", "White", "Yellow"};

            comboBox.Items.Clear();
            comboBox.Items.AddRange(colors);
            comboBox.Text = colors[0];

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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
            //no duplicate colors

            int blue = 0;
            int green = 0;
            int magenta = 0;
            int red = 0;
            int white = 0;
            int yellow = 0;

            List<char> list = new List<char>();

            list.AddRange(new char[] { colorComboBox1.Text[0], colorComboBox2.Text[0], colorComboBox3.Text[0], colorComboBox4.Text[0], colorComboBox5.Text[0] } );

            foreach (char character in list)
            {
                switch (character)
                {
                    case 'B':
                        blue++;
                        break;

                    case 'G':
                        green++;
                        break;

                    case 'M':
                        magenta++;
                        break;

                    case 'R':
                        red++;
                        break;

                    case 'W':
                        white++;
                        break;

                    case 'Y':
                        yellow++;
                        break;
                }

                if (blue > 1 || green > 1 || magenta > 1 || red > 1 || white > 1 || yellow > 1)
                {
                    ShowErrorMessage("Can't have duplicate colors", "Light Cycle Error");
                    return;
                }

                new LightCycle(Bomb, LogFileWriter, string.Join("", list));
                UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
            }


        }
    }
}
