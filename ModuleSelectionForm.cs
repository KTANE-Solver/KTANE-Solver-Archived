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
    public partial class ModuleSelectionForm : Form
    {
        private Bomb bomb;
        EdgeworkConfirmationForm confirmationForm;
        EdgeworkInputForm inputForm;

        public ModuleSelectionForm()
        {
            InitializeComponent();
        }

        public ModuleSelectionForm(Bomb bomb, EdgeworkConfirmationForm confirmationForm, EdgeworkInputForm inputForm)
        {
            InitializeComponent();
            this.bomb = bomb;
            this.confirmationForm = confirmationForm;
            this.inputForm = inputForm;
        }
    }
}
