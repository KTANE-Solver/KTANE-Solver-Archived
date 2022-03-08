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
    public partial class AstrologyForm : ModuleForm
    {
        //the name of the selected images
        private String image1Name;
        private String image2Name;
        private String image3Name;

        public AstrologyForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm) 
        : base(bomb, logFileWriter, moduleSelectionForm, "Astrology", false)
        {
            InitializeComponent();

            airButton.Image = SetUpImage("Air");
            aquariusButton.Image = SetUpImage("Aquarius");
            ariesButton.Image = SetUpImage("Aries");
            cancerButton.Image = SetUpImage("Cancer");
            capricornButton.Image = SetUpImage("Capricorn");
            earthButton.Image = SetUpImage("Earth");
            fireButton.Image = SetUpImage("Fire");
            geminiButton.Image = SetUpImage("Gemini");
            jupiterButton.Image = SetUpImage("Jupiter");
            leoButton.Image = SetUpImage("Leo");
            libraButton.Image = SetUpImage("Libra");
            marsButton.Image = SetUpImage("Mars");
            mercuryButton.Image = SetUpImage("Mercury");
            moonButton.Image = SetUpImage("Moon");
            neptuneButton.Image = SetUpImage("Neptune");
            piscesButton.Image = SetUpImage("Pisces");
            plutoButton.Image = SetUpImage("Pluto");
            sagittariusButton.Image = SetUpImage("Sagittarius");
            saturnButton.Image = SetUpImage("Saturn");
            scorpioButton.Image = SetUpImage("Scorpio");
            sunButton.Image = SetUpImage("Sun");
            taurusButton.Image = SetUpImage("Taurus");
            uranusButton.Image = SetUpImage("Uranus");
            venusButton.Image = SetUpImage("Venus");
            virgoButton.Image = SetUpImage("Virgo");
            waterButton.Image = SetUpImage("Water");

            //set up event triggers for each buttons
            airButton.Click += new EventHandler(AddSelection);
            aquariusButton.Click += new EventHandler(AddSelection);
            ariesButton.Click += new EventHandler(AddSelection);
            cancerButton.Click += new EventHandler(AddSelection);
            capricornButton.Click += new EventHandler(AddSelection);
            earthButton.Click += new EventHandler(AddSelection);
            fireButton.Click += new EventHandler(AddSelection);
            geminiButton.Click += new EventHandler(AddSelection);
            jupiterButton.Click += new EventHandler(AddSelection);
            leoButton.Click += new EventHandler(AddSelection);
            libraButton.Click += new EventHandler(AddSelection);
            marsButton.Click += new EventHandler(AddSelection);
            mercuryButton.Click += new EventHandler(AddSelection);
            moonButton.Click += new EventHandler(AddSelection);
            neptuneButton.Click += new EventHandler(AddSelection);
            piscesButton.Click += new EventHandler(AddSelection);
            plutoButton.Click += new EventHandler(AddSelection);
            sagittariusButton.Click += new EventHandler(AddSelection);
            saturnButton.Click += new EventHandler(AddSelection);
            scorpioButton.Click += new EventHandler(AddSelection);
            sunButton.Click += new EventHandler(AddSelection);
            taurusButton.Click += new EventHandler(AddSelection);
            uranusButton.Click += new EventHandler(AddSelection);
            venusButton.Click += new EventHandler(AddSelection);
            virgoButton.Click += new EventHandler(AddSelection);
            waterButton.Click += new EventHandler(AddSelection);

            selectedImageButton1.Click += new EventHandler(DeleteSelection);
            selectedImageButton2.Click += new EventHandler(DeleteSelection);
            selectedImageButton3.Click += new EventHandler(DeleteSelection);

        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            selectedImageButton1.Image = null;
            selectedImageButton2.Image = null;
            selectedImageButton3.Image = null;
        }
        /// <summary>
        /// Gets images from the astrology folder
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private Image SetUpImage(String fileName)
        {
            return Image.FromFile($"Astrology Pictures/{fileName}.png");
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

        }

        /// <summary>
        /// Adds the image the user selected as one of the selected 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSelection(object sender, EventArgs e)
        {
            System.Windows.Forms.Button selectedButton = (System.Windows.Forms.Button)sender;

            //the image that was selected
            Image selectedImage = selectedButton.Image;





            //check to see if the selection is full and if the selected image is already selected,
            //if neither add the selected image to the current selection
            if (SelectedImageNum() != 3 && !ImageSelected(selectedImage))
            {
                String fileName = null;


                //finding which button was selected
                if (selectedButton == airButton)
                    fileName = "Air";

                else if (selectedButton == aquariusButton)
                    fileName = "Aquarius";

                else if (selectedButton == ariesButton)
                    fileName = "Aries";

                else if (selectedButton == cancerButton)
                    fileName = "Cancer";

                else if (selectedButton == capricornButton)
                    fileName = "Capricorn";

                else if (selectedButton == earthButton)
                    fileName = "Earth";

                else if (selectedButton == fireButton)
                    fileName = "Fire";

                else if (selectedButton == geminiButton)
                    fileName = "Gemini";

                else if (selectedButton == jupiterButton)
                    fileName = "Jupiter";

                else if (selectedButton == leoButton)
                    fileName = "Leo";

                else if (selectedButton == libraButton)
                    fileName = "Libra";

                else if (selectedButton == marsButton)
                    fileName = "Mars";

                else if (selectedButton == mercuryButton)
                    fileName = "Mercury";

                else if (selectedButton == moonButton)
                    fileName = "Moon";

                else if (selectedButton == neptuneButton)
                    fileName = "Neptune";

                else if (selectedButton == piscesButton)
                    fileName = "Pisces";

                else if (selectedButton == plutoButton)
                    fileName = "Pluto";

                else if (selectedButton == sagittariusButton)
                    fileName = "Sagittarius";

                else if (selectedButton == saturnButton)
                    fileName = "Saturn";

                else if (selectedButton == scorpioButton)
                    fileName = "Scorpio";

                else if (selectedButton == sunButton)
                    fileName = "Sun";

                else if (selectedButton == taurusButton)
                    fileName = "Taurus";

                else if (selectedButton == uranusButton)
                    fileName = "Uranus";

                else if (selectedButton == venusButton)
                    fileName = "Venus";

                else if (selectedButton == virgoButton)
                    fileName = "Virgo";

                else if (selectedButton == waterButton)
                    fileName = "Water";


                if (selectedImageButton1.Image == null)
                {
                    selectedImageButton1.Image = selectedImage;
                    image1Name = fileName;
                }

                else if (selectedImageButton2.Image == null)
                {
                    selectedImageButton2.Image = selectedImage;
                    image2Name = fileName;
                }

                else if (selectedImageButton3.Image == null)
                {
                    selectedImageButton3.Image = selectedImage;
                    image3Name = fileName;
                }
            }
        }

        /// <summary>
        /// A method that will delete an image from the current selection
        /// and shift the other images to the left
        /// </summary>
        private void DeleteSelection(object sender, EventArgs e)
        {
            System.Windows.Forms.Button selectedButton = (System.Windows.Forms.Button)sender;

            selectedButton.Image = null;

            if (selectedButton == selectedImageButton2)
            {
                selectedImageButton2.Image = selectedImageButton3.Image;
                image2Name = image3Name;

                selectedImageButton3.Image = null;
            }

            else if (selectedButton == selectedImageButton1)
            {
                selectedImageButton1.Image = selectedImageButton2.Image;
                image1Name = image2Name;

                selectedImageButton2.Image = selectedImageButton3.Image;
                image2Name = image3Name;

                selectedImageButton3.Image = null;
            }
        }

        /// <summary>
        /// Tells how many images are currently selected
        /// </summary>
        /// <returns></returns>
        private int SelectedImageNum()
        {

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
                   selectedImageButton3.Image == selectedImage;
        }
    }
}
