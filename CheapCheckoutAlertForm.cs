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
    public partial class CheapCheckoutAlertForm : ModuleForm
    {
        decimal total;

        public CheapCheckoutAlertForm(decimal total)
        {
            InitializeComponent();
            this.total = total;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //check to make sure text box converts to double
            Decimal amount;

            try
            {
                amount = Decimal.Parse(newAmountTextBox.Text);
            }

            catch
            {
                ShowErrorMessage("Invalid amount", "Cheap Checkout Error");
                return;
            }

            //make sure amount only has to decimals

            if (Decimal.Round(amount, 2) != amount)
            {
                ShowErrorMessage("Amount should only have 2 decimals", "Cheap Checkout Error");
                return;
            }

            //new amount cant be lower than total
            if (amount < total)
            {
                ShowErrorMessage("New amount can't be less than total", "Cheap Checkout Error");
                return;
            }

            decimal answer = RoundPrice(amount - total);

            System.Diagnostics.Debug.WriteLine($"Answer: ${answer}\n");
            ShowAnswer($"${string.Format("{0:0.00}", answer)}", "Cheap Checkout Answer");

            this.Hide();
        }

        private Decimal RoundPrice(Decimal oldPrice)
        {
            //round the price
            return Math.Round(oldPrice, 2, MidpointRounding.AwayFromZero);

        }
    }
}
