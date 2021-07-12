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
    public partial class _3DMazeForm : ModuleForm
    {
        public _3DMazeForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            threeLettersTextBox.Text = "";
            pathTextBox.Text = "";
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
            String threeLetters = threeLettersTextBox.Text.ToUpper();

            if (threeLetters.Length != 3)
            {
                MessageBox.Show("There must only be 3 letters in the first text box", "3D Maze Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<char> characters = new List<char>();

            characters.Add(threeLetters[0]);
            characters.Add(threeLetters[1]);
            characters.Add(threeLetters[2]);

            if (!(ContainsLetters('A','B','C', characters) || ContainsLetters('A', 'B', 'D', characters) || ContainsLetters('A', 'B', 'H', characters) ||
                ContainsLetters('A','D','C', characters) || ContainsLetters('A', 'C', 'H', characters) || ContainsLetters('A', 'D', 'H', characters) ||
                ContainsLetters('B','D','C', characters) || ContainsLetters('B', 'D', 'H', characters) || ContainsLetters('C', 'B', 'H', characters)))
            {
                MessageBox.Show("Invalid three letters in the first text box", "3D Maze Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _3DMaze module = new _3DMaze(Bomb, LogFileWriter);

            module.CreateGrid(characters);

            List<char> spots = new List<char>();
            spots.AddRange(pathTextBox.Text.ToUpper());

            List<int[]> coordinateList = module.FindLocation(spots);

            if (coordinateList == null)
            {
                MessageBox.Show("Invalid Path", "3D Maze Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String pointOfDirection;
            int endRow;
            int endColumn;

            if (coordinateList.Count > 1)
            {
                foreach (int[] coor in coordinateList)
                {
                    switch (coor[2])
                    {
                        case 0:
                            pointOfDirection = "North";

                            endRow = coor[0] - ((spots.Count - 1) * 2);

                            if (endRow > 15)
                            {
                                endRow -= 16;
                            }

                            endColumn = coor[1];

                            break;

                        case 1:
                            pointOfDirection = "East";

                            endColumn = coor[1] + ((spots.Count - 1) * 2);

                            if (endColumn > 15)
                            {
                                endColumn -= 16;
                            }

                            endRow = coor[0];

                            break;

                        case 2:
                            pointOfDirection = "South";

                            endRow = coor[0] + ((spots.Count - 1) * 2);

                            if (endRow < 0)
                            {
                                endRow += 16;
                            }

                            endColumn = coor[1];

                            break;

                        default:
                            pointOfDirection = "West";

                            endColumn = coor[1] - ((spots.Count - 1) * 2);

                            if (endColumn < 0)
                            {
                                endColumn += 16;
                            }

                            endRow = coor[0];

                            break;
                    }

                    System.Diagnostics.Debug.WriteLine($"User is pointing {pointOfDirection} at {endRow} {endColumn}. Started at {coor[0]} {coor[1]}");
                }

                MessageBox.Show("Multiple paths found. Try another", "3D Maze Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int[] coordinate = coordinateList[0];

            switch (coordinate[2])
            {
                case 0:
                    pointOfDirection = "North";

                    endRow = coordinate[0] - ((spots.Count - 1) * 2);

                    if (endRow > 15)
                    {
                        endRow -= 16;
                    }

                    endColumn = coordinate[1];

                    break;

                case 1:
                    pointOfDirection = "East";

                    endColumn = coordinate[1] + ((spots.Count - 1) * 2);

                    if (endColumn > 15)
                    {
                        endColumn -= 16;
                    }

                    endRow = coordinate[0];

                    break;

                case 2:
                    pointOfDirection = "South";

                    endRow = coordinate[0] + ((spots.Count - 1) * 2);

                    if (endRow < 0)
                    {
                        endRow += 16;
                    }

                    endColumn = coordinate[1];

                    break;

                default:
                    pointOfDirection = "West";

                    endColumn = coordinate[1] - ((spots.Count - 1) * 2);

                    if (endColumn < 0)
                    {
                        endColumn += 16;
                    }

                    endRow = coordinate[0];
                    break;
            }

            endRow /= 2;
            endColumn /= 2;

            System.Diagnostics.Debug.WriteLine($"User is pointing {pointOfDirection} at {endRow} {endColumn}");


            module.currentRow = endRow;
            module.currentColumn = endColumn;

            module.Solve();

        }


        private bool ContainsLetters(char one, char two, char three, List<char> characters)
        {
            return characters.Contains(one) && characters.Contains(two) && characters.Contains(three);
        }
        private void _3DMazeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram(e);
        }
    }
}
