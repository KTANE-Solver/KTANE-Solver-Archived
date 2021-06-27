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
    //Date 6/9/21
    //Purpose: Gets the information needed to solve "Cheap Checkout"
    public partial class CheapCheckoutForm : ModuleForm
    {
        public CheapCheckoutForm(Bomb bomb, ModuleSelectionForm moduleSelectionForm, StreamWriter logFileWriter)
        {
            InitializeComponent();
            UpdateForm(bomb, moduleSelectionForm, logFileWriter);
        }

        /// <summary>
        /// Updates the form so it looks brand new
        /// </summary>
        public void UpdateForm(Bomb bomb, ModuleSelectionForm moduleSelectionForm, StreamWriter logFileWriter)
        {
            Bomb = bomb;
            ModuleSelectionForm = moduleSelectionForm;
            LogFileWriter = logFileWriter;

            amountTextBox.Text = "";

            SetUpFixedComboBox(item1ComboBox);
            SetUpFixedComboBox(item2ComboBox);
            SetUpFixedComboBox(item3ComboBox);
            SetUpFixedComboBox(item4ComboBox);

            SetUpWeightedComboBox(item5ComboBox);
            SetUpWeightedComboBox(item6ComboBox);

            SetUpWeightComboBox(item5WeightComboBox);
            SetUpWeightComboBox(item6WeightComboBox);
        }

        /// <summary>
        /// Sets up the comboBox that contain fixed items
        /// </summary>
        private void SetUpFixedComboBox(ComboBox comboBox)
        {
            String[] fixedItems = new string[] { "Candy Canes", "Canola Oil",
             "Cereal", "Cheese", "Chocolate Bar", "Chocolate Milk", "Coffee Beans",
             "Cookies",  "Deodorant", "Fruit Punch", "Grape Jelly", "Grapefruit",
                "Gum", "Honey", "Ketchup", "Lollipops", "Lotion", "Mayonnaise", "Mints",
                "Mustard", "Oranges", "Paper Towels", "Pasta Sauce", "Peanut Butter",
                "Pork", "Potato Chips", "Shampoo", "Socks", "Soda", "Spaghetti", "Sugar", "Tea",
                "Tissues", "Toothpaste", "Water Bottles", "White Bread", "White Milk"  };

            comboBox.Items.Clear();
            comboBox.Items.AddRange(fixedItems);
            comboBox.Text = fixedItems[0];
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Sets up the comboBox that contain weighted items
        /// </summary>
        private void SetUpWeightedComboBox(ComboBox comboBox)
        {
            String[] items = new string[] { "Bananas", "Broccoli",
           "Chicken", "Grapefruit", "Lemons", "Lettuce", "Oranges", 
                "Pork", "Potatoes", "Steak", "Tomatoes", "Turkey" };

            comboBox.Items.Clear();
            comboBox.Items.AddRange(items);
            comboBox.Text = items[0];
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Sets up the comboBox that contain wieghts
        /// </summary>
        private void SetUpWeightComboBox(ComboBox comboBox)
        {
            String[] wieghts = new string[] { "0.5", "1.0", "1.5" };
            comboBox.Items.Clear();
            comboBox.Items.AddRange(wieghts);
            comboBox.Text = wieghts[0];
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {


            String item1 = item1ComboBox.Text;
            String item2 = item2ComboBox.Text;
            String item3 = item3ComboBox.Text;
            String item4 = item4ComboBox.Text;
            String item5 = item5ComboBox.Text;
            String item6 = item6ComboBox.Text;


            double item5Weight = Double.Parse(item5WeightComboBox.Text);
            double item6Weight = Double.Parse(item6WeightComboBox.Text);
            int amount;

            try
            {
                amount = Int32.Parse(amountTextBox.Text);
            }

            catch
            {
                MessageBox.Show("Invalid amount", "Cheap Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //make sure amount only has to decimals

            if (Decimal.Round(amount, 2) != amount)
            {
                MessageBox.Show("Amount should only have 2 decimals", "Cheap Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //no duplicate items

            if (item1 == item2 ||
                item1 == item3 ||
                item1 == item4 ||
                item2 == item3 ||
                item2 == item4 ||
                item3 == item4 ||
                item5 == item6)
            {
                MessageBox.Show("Can't have duplicate items", "Cheap Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            CheapCheckout module = new CheapCheckout(Bomb, LogFileWriter, amount, item1, item2, item3, item4, item5Weight, item5, item6Weight, item6);
            
            module.Solve();

            UpdateForm(Bomb, ModuleSelectionForm, LogFileWriter);
        }

        private void CheapCheckoutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram(e);
        }
    }
}
