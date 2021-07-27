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
    //Author: Nya Bentley
    //Date: 3/4/21
    //Purpose: Gets the infomration needed 
    //to solve the Maze module
    public partial class MazeForm : ModuleForm
    {
        //the 2d array that will hold buttons
        //that will represent the gird
        private System.Windows.Forms.Button[,] buttonArray;

        //used to solve the module
        private Maze maze;
        
        /// <summary>
        /// Creates the maze form
        /// </summary>
        /// <param name="moduleSelectionForm">the form used to get to this form</param>
        public MazeForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm): base(bomb, logFileWriter, moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);

        }

        /// <summary>
        /// Sets up this form so it looks new
        /// </summary>
        /// <param name="moduleSelectionForm">the form used to get to this form</param>
        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            //centers and positions all the labels
            redLabel.Left = (this.Width - redLabel.Width) / 2;
            orangeLabel.Left = (this.Width - orangeLabel.Width) / 2;
            yellowLabel.Left = (this.Width - yellowLabel.Width) / 2;
            greenLabel.Left = (this.Width - greenLabel.Width) / 2;
            blueLabel.Left = (this.Width - blueLabel.Width) / 2;
            whiteLabel.Left = (this.Width - whiteLabel.Width) / 2;

            mazeBox.Left = (this.Width - mazeBox.Width) / 2;

            redLabel.Location = new Point(redLabel.Location.X, (mazeBox.Location.Y / 8) * 2);
            orangeLabel.Location = new Point(orangeLabel.Location.X, (mazeBox.Location.Y / 8) * 3);
            yellowLabel.Location = new Point(yellowLabel.Location.X, (mazeBox.Location.Y / 8) * 4);
            greenLabel.Location = new Point(greenLabel.Location.X, (mazeBox.Location.Y / 8) * 5);
            blueLabel.Location = new Point(blueLabel.Location.X, (mazeBox.Location.Y / 8) * 6);
            whiteLabel.Location = new Point(whiteLabel.Location.X, (mazeBox.Location.Y / 8) * 7);

            //changes the y positions of the buttons so the title of
            //the mze can be seen
            int YOffset = 12;

            buttonArray = new System.Windows.Forms.Button[6, 6];

            mazeBox.Controls.Clear();

            int buttonWidth = mazeBox.Width / 6;
            int buttonHeight = (mazeBox.Height - YOffset) / 6;

            //creating each button and setting it in
            //mapBox and buttonArray
            for (int row = 0; row < 6; row++)
            {
                for (int column = 0; column < 6; column++)
                {
                    System.Windows.Forms.Button button = new System.Windows.Forms.Button();


                    button.Width = buttonWidth;
                    button.Height = buttonHeight;

                    button.BackColor = Color.Blue;

                    int XCoordinate = column * buttonWidth;
                    int YCoordinate = (row * buttonHeight) + YOffset;

                    Point location = new Point(XCoordinate, YCoordinate);

                    button.Location = location;

                    button.Click += new EventHandler(button_Click);
                    mazeBox.Controls.Add(button);

                    buttonArray[row, column] = button;
                }
            }
        }

        /// <summary>
        /// Changes the button's color when they are clicked
        /// </summary>
        private void button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button) sender;


            if (button.BackColor == Color.Blue)
            {
                button.BackColor = Color.Red;
            }

            else if (button.BackColor == Color.Red)
            { 
                button.BackColor = Color.Orange;
            }

            else if (button.BackColor == Color.Orange)
            {
                button.BackColor = Color.Yellow;
            }

            else if (button.BackColor == Color.Yellow)
            {
                button.BackColor = Color.Green;
            }

            else if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.White;
            }

            else if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Blue;
            }
        }

        /// <summary>
        /// Sends the user back to the moduleSelection form
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        /// <summary>
        /// Makes sure the user gave valid information to solve the
        /// maze module
        /// </summary>
        private void submitButton_Click(object sender, EventArgs e)
        {
            //count the number of objects found in the array
            int playersFound = 0;
            int goalsFound = 0;
            int markersFound = 0;

            int playerRow = -1;
            int playerColumn = -1;

            int goalRow = -1;
            int goalColumn = -1;

            int markerRow = -1;
            int markerColumn = -1;

            foreach (System.Windows.Forms.Button button in buttonArray)
            {
                if (button.BackColor == Color.Red)
                {
                    goalsFound++;
                }

                else if (button.BackColor == Color.Orange)
                {
                    goalsFound++;
                    markersFound++;
                }

                else if (button.BackColor == Color.Yellow)
                {
                    playersFound++;
                    markersFound++;
                }

                else if (button.BackColor == Color.Green)
                {
                    markersFound++;
                }

                else if (button.BackColor == Color.White)
                {
                    playersFound++;
                }
            }

            //if there isn't 1 player, the maze is invalid
            if (playersFound != 1)
            {
                String text = "There needs to be 1 player. Found " + playersFound;
                String caption = "Invalid Player Number";

                ShowErrorMessage(text, caption);
                return;
            }

            //if there isn't 1 goal, the maze is invalid
            if (goalsFound != 1)
            {
                String text = "There needs to be 1 goal. Found " + goalsFound;
                String caption = "Invalid Goal Number";

                ShowErrorMessage(text, caption);
                return;
            }

            //if there isn't 1 or 2 markers, the maze is invalid
            if (markersFound != 1 && markersFound != 2)
            {
                String text = "There needs to be 1 or 2 markers. Found " + markersFound;
                String caption = "Invalid Marker Number";

                ShowErrorMessage(text, caption);
                return;
            }

            //if there is a marker is found in any of these places, they're invalid


            //(1,3) (1,6) (2,2) (2,4) (2,6) (3,1) (3,2) (3,3) (3,4) (4,5) (5,2) (5,4) (5,5) (5,6) (6,1) (6,3) (6,5) (6,6)
            if (buttonArray[0, 2].BackColor == Color.Green || buttonArray[0, 5].BackColor == Color.Green || buttonArray[1, 1].BackColor == Color.Green ||
                buttonArray[1, 3].BackColor == Color.Green || buttonArray[1, 5].BackColor == Color.Green || buttonArray[2, 0].BackColor == Color.Green ||
                buttonArray[2, 1].BackColor == Color.Green || buttonArray[3, 4].BackColor == Color.Green || buttonArray[4, 3].BackColor == Color.Green ||
                buttonArray[4, 4].BackColor == Color.Green || buttonArray[4, 5].BackColor == Color.Green || buttonArray[5, 0].BackColor == Color.Green ||
                buttonArray[5, 2].BackColor == Color.Green || buttonArray[5, 4].BackColor == Color.Green || buttonArray[5, 5].BackColor == Color.Green)
            {
                ShowErrorMessage("There is an invalid marker inputted on the maze", "Invalid Marker");
                return;
            }

            //if there are 2 markers, make sure they're valid pairs

            if(markersFound == 2)
            {
                //(2,1) (3,6)
                //(2,5) (4,2)
                //(4,4) (4,6)
                //(1,1) (4,1)
                //(3,5) (6,4)
                //(1,5) (5,3)
                //(1,4) (4,3)
                //(1,2) (6,2)
                //(2,3) (5,1)

                if ((buttonArray[1, 0].BackColor == Color.Green && buttonArray[2, 5].BackColor != Color.Green) ||
                    (buttonArray[1, 4].BackColor == Color.Green && buttonArray[3, 1].BackColor != Color.Green) ||
                    (buttonArray[3, 3].BackColor == Color.Green && buttonArray[3, 5].BackColor != Color.Green) ||
                    (buttonArray[0, 0].BackColor == Color.Green && buttonArray[3, 0].BackColor != Color.Green) ||
                    (buttonArray[2, 4].BackColor == Color.Green && buttonArray[5, 3].BackColor != Color.Green) ||
                    (buttonArray[0, 4].BackColor == Color.Green && buttonArray[4, 2].BackColor != Color.Green) ||
                    (buttonArray[0, 1].BackColor == Color.Green && buttonArray[5, 1].BackColor != Color.Green) ||
                    (buttonArray[0, 3].BackColor == Color.Green && buttonArray[3, 2].BackColor != Color.Green) ||
                    (buttonArray[1, 2].BackColor == Color.Green && buttonArray[4, 0].BackColor != Color.Green))

                {
                    ShowErrorMessage("There is an invalid pair of markers", "Invalid Marker Pair");
                    return;
                }
            }

            //finding the goal, player, and marker
            for(int row = 0; row < 6; row++)
            {
                for (int column = 0; column < 6; column++)
                {
                    //red - goal
                    if (buttonArray[row, column].BackColor == Color.Red)
                    {
                        goalRow = row;
                        goalColumn = column;
                    }

                    //orange - goal + maker
                    else if (buttonArray[row, column].BackColor == Color.Orange)
                    {
                        goalRow = row;
                        goalColumn = column;

                        markerRow = row;
                        markerColumn = column;
                    }

                    //yellow - player + marker
                    else if (buttonArray[row, column].BackColor == Color.Yellow)
                    {
                        playerRow = row;
                        playerColumn = column;

                        markerRow = row;
                        markerColumn = column;
                    }

                    //green - marker
                    else if (buttonArray[row, column].BackColor == Color.Green)
                    {
                        markerRow = row;
                        markerColumn = column;
                    }

                    //white - player
                    else if (buttonArray[row, column].BackColor == Color.White)
                    {
                        playerRow = row;
                        playerColumn = column;
                    }
                }
            }

            //solving maze
            maze = new Maze(playerRow + 1, playerColumn + 1, goalRow + 1, goalColumn + 1, markerRow + 1, markerColumn + 1, LogFileWriter);
            maze.Solve();

            UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
        }

        /// <summary>
        /// Adds a stirke to the total
        /// </summary>
        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }
    }
}
