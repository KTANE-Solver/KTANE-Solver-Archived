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
    public partial class _3DMazeForm : ModuleForm
    {
        _3DMaze module;

        public _3DMazeForm(Bomb bomb, StreamWriter logFile, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateEdgeWork(bomb, logFile, moduleSelectionForm);
            module = new _3DMaze(bomb, logFile);
            module.SetMaze('B', 'C', 'H');
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFile, ModuleSelectionForm moduleSelectionForm)
        { 
            UpdateEdgeWork(bomb, logFile, moduleSelectionForm);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            module.PrintGrid();
        }
    }
}
