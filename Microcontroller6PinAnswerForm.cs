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
    public partial class Microcontroller6PinAnswerForm : ModuleForm
    {
        public Microcontroller6PinAnswerForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm, Microcontroller.Pin.Color button1Color, Microcontroller.Pin.Color button2Color, Microcontroller.Pin.Color button3Color, Microcontroller.Pin.Color button4Color, Microcontroller.Pin.Color button5Color, Microcontroller.Pin.Color button6Color) : base(bomb, logFileWriter, moduleSelectionForm, "Microcontroller", true)
        {
            InitializeComponent();
        }
    }
}
