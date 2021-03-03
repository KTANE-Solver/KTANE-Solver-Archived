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
    //Author: Nya Bentley
    //Date: 3/1/21
    //Purpose: Shows the edgework the user inputted
    //         and asks for confirmation
    public partial class EdgeworkConfirmationForm : Form
    {
        //FIELDS
        
        //the form the user will go to if they press backButton
        EdgeworkInputForm inputForm;
        
        //where the edgework will be read from
        Bomb bomb;

        /// <summary>
        /// Tells the user what the edgework is
        /// </summary>
        /// <param name="bomb">the bomb that was created</param>
        public EdgeworkConfirmationForm(Bomb bomb)
        {
            InitializeComponent();
            inputForm = new EdgeworkInputForm();
            UpdateForm(bomb);

        }

        public EdgeworkConfirmationForm(Bomb bomb, EdgeworkInputForm inputForm)
        {
            InitializeComponent();
            UpdateForm(bomb, inputForm);
        }

        public void UpdateForm(Bomb bomb)
        { 
            
        }

        public void UpdateForm(Bomb bomb, EdgeworkInputForm inputForm)
        {
            this.inputForm = inputForm;
            this.bomb = bomb;
        }



    }
}
