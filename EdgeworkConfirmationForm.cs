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
    public partial class EdgeworkConfirmationForm : Form
    {
        /// <summary>
        /// Tells the user what the edgework is
        /// </summary>
        /// <param name="bomb">the bomb that was created</param>
        public EdgeworkConfirmationForm(Bomb bomb)
        {
            
            InitializeComponent();
        }



    }
}
