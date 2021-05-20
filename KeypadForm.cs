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
    //Purpose: gets the information needed to solve "Keypad"
    public partial class KeypadForm : ModuleForm
    {

        public KeypadForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm) : base(bomb, logFileWriter, moduleSelectionForm)
        {
            InitializeComponent();

            //setting up the imaages for the buttons
            threeButton.Image = SetUpImage("3");
            sixButton.Image = SetUpImage("6");
            aButton.Image = SetUpImage("A");
            aeButton.Image = SetUpImage("AE");
            bButton.Image = SetUpImage("B");
            backwardsCButton.Image = SetUpImage("Backwards C");
            blackStarButton.Image = SetUpImage("Black Star");
            buttButton.Image = SetUpImage("Butt");
            cButton.Image = SetUpImage("C");
            copyrightButton.Image = SetUpImage("Copyright");
            eButton.Image = SetUpImage("E");
            hButton.Image = SetUpImage("H");
            hashtagButton.Image = SetUpImage("Hashtag");
            lambdaButton.Image = SetUpImage("Lambda");
            lightningButton.Image = SetUpImage("Lightning");
            nButton.Image = SetUpImage("N");
            oButton.Image = SetUpImage("O");
            omegaButton.Image = SetUpImage("Omega");
            paragraphButton.Image = SetUpImage("Paragraph");
            questionMarkButton.Image = SetUpImage("Question Mark");
            smilyFaceButton.Image = SetUpImage("Smily Face");
            squidButton.Image = SetUpImage("Squid");
            swirlButton.Image = SetUpImage("Swirl");
            tridentButton.Image = SetUpImage("Trident");
            unfinishedRButton.Image = SetUpImage("Unfinished R");
            whiteStarButton.Image = SetUpImage("White Star");
            xButton.Image = SetUpImage("X");

            //set up event triggers for each buttons
            threeButton.Click += new EventHandler(AddSelection);
            sixButton.Click += new EventHandler(AddSelection);
            aButton.Click += new EventHandler(AddSelection);
            aeButton.Click += new EventHandler(AddSelection);
            bButton.Click += new EventHandler(AddSelection);
            backwardsCButton.Click += new EventHandler(AddSelection);
            blackStarButton.Click += new EventHandler(AddSelection);
            buttButton.Click += new EventHandler(AddSelection);
            cButton.Click += new EventHandler(AddSelection);
            copyrightButton.Click += new EventHandler(AddSelection);
            eButton.Click += new EventHandler(AddSelection);
            hButton.Click += new EventHandler(AddSelection);
            hashtagButton.Click += new EventHandler(AddSelection);
            lambdaButton.Click += new EventHandler(AddSelection);
            lightningButton.Click += new EventHandler(AddSelection);
            nButton.Click += new EventHandler(AddSelection);
            oButton.Click += new EventHandler(AddSelection);
            omegaButton.Click += new EventHandler(AddSelection);
            paragraphButton.Click += new EventHandler(AddSelection);
            questionMarkButton.Click += new EventHandler(AddSelection);
            smilyFaceButton.Click += new EventHandler(AddSelection);
            squidButton.Click += new EventHandler(AddSelection);
            swirlButton.Click += new EventHandler(AddSelection);
            tridentButton.Click += new EventHandler(AddSelection);
            unfinishedRButton.Click += new EventHandler(AddSelection);
            whiteStarButton.Click += new EventHandler(AddSelection);
            xButton.Click += new EventHandler(AddSelection);
            
            selectedImageButton1.Click += new EventHandler(DeleteSelection);
            selectedImageButton2.Click += new EventHandler(DeleteSelection);
            selectedImageButton3.Click += new EventHandler(DeleteSelection);
            selectedImageButton4.Click += new EventHandler(DeleteSelection);

        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            Bomb = bomb;
            LogFileWriter = logFileWriter;
            ModuleSelectionForm = moduleSelectionForm;

            selectedImageButton1.Image = null;
            selectedImageButton2.Image = null;
            selectedImageButton3.Image = null;
            selectedImageButton4.Image = null;

        }

        /// <summary>
        /// A helper method that will load 
        /// the images for the buttons
        /// </summary>
        /// <param name="fileName">the name of the image</param>
        private Image SetUpImage(String fileName)
        {
            return Image.FromFile($"Keypad Pictures/{fileName}.png");
        }

        /// <summary>
        /// A method that will add image to the current selection as long as 
        /// the selection isn't full and the image isn't already selected
        /// </summary>
        private void AddSelection(object sender, EventArgs e)
        {
            //the image that was selected
            Image selectedImage = ((Button)sender).Image;

            //check to see if the selection is full and if the selected image is already selected,
            //if neither add the selected image to the current selection
            if (SelectedImageNum() != 4 && !ImageSelected(selectedImage))
            {
                if (selectedImageButton1.Image == null)
                    selectedImageButton1.Image = selectedImage;

                else if (selectedImageButton2.Image == null)
                    selectedImageButton2.Image = selectedImage;

                else if (selectedImageButton3.Image == null)
                    selectedImageButton3.Image = selectedImage;

                else if (selectedImageButton4.Image == null)
                    selectedImageButton4.Image = selectedImage;
            }

        }

        /// <summary>
        /// A method that will delete an image from the current selection
        /// and shift the other images to the left
        /// </summary>
        private void DeleteSelection(object sender, EventArgs e)
        {
            Button selectedButton = (Button)sender;

            selectedButton.Image = null;

            if (selectedButton == selectedImageButton3)
            {
                selectedImageButton3.Image = selectedImageButton4.Image;
                selectedImageButton4.Image = null;
            }

            else if (selectedButton == selectedImageButton2)
            {
                selectedImageButton2.Image = selectedImageButton3.Image;
                selectedImageButton3.Image = selectedImageButton4.Image;
                selectedImageButton4.Image = null;
            }

            else if (selectedButton == selectedImageButton1)
            {
                selectedImageButton1.Image = selectedImageButton2.Image;
                selectedImageButton2.Image = selectedImageButton3.Image;
                selectedImageButton3.Image = selectedImageButton4.Image;
                selectedImageButton4.Image = null;
            }
        }

        /// <summary>
        /// A helper method that will tell how many selected images there are
        /// </summary>
        private int SelectedImageNum()
        {
            if (selectedImageButton4.Image != null)
                return 4;

            if (selectedImageButton3.Image != null)
                return 3;

            if (selectedImageButton2.Image != null)
                return 2;

            if (selectedImageButton1.Image != null)
                return 1;

            return 0;
        }

        /// <summary>
        /// Tells if an image has already been selected
        /// </summary>
        private bool ImageSelected(Image selectedImage)
        {
            return selectedImageButton1.Image == selectedImage ||
                   selectedImageButton2.Image == selectedImage ||
                   selectedImageButton3.Image == selectedImage ||
                   selectedImageButton4.Image == selectedImage;
        }

        private void KeypadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram(e);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //must have 4 image
            if (SelectedImageNum() != 4)
            {
                MessageBox.Show("Must have 4 images to continue", "KeyPad Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }
    }
}
