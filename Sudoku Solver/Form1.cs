using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;

            switch (key)
            {
                case 37:

                    break;
                case 38:

                    break;
                case 39:
                    this.ActiveControl = tb12;
                    break;
                case 40:

                    break;
            }
        }
    }
}
