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
    public partial class CheapCheckoutAlertForm : Form
    {
        double total;

        CheapCheckout.Item item1;
        CheapCheckout.Item item2;
        CheapCheckout.Item item3;
        CheapCheckout.Item item4;
        CheapCheckout.Item item5;
        CheapCheckout.Item item6;


        public CheapCheckoutAlertForm(CheapCheckout.Item item1, CheapCheckout.Item item2, CheapCheckout.Item item3, CheapCheckout.Item item4, CheapCheckout.Item item5, CheapCheckout.Item item6, double total)
        {
            InitializeComponent();

            this.total = total;

            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;
            this.item6 = item6;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //check to make sure text box converts to double
            int amount;

            try
            {
                amount = int.Parse(newAmountTextBox.Text);
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

            //new amount cant be lower than total
            if (amount < total)
            {
                MessageBox.Show("New amount can't be less than total", "Cheap Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"${amount - total}", "Cheap Checkout Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }
    }
}
