using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnumero1.Text);
            int num2 = int.Parse(txtnumero2.Text);

            if (num1 > num2)
            {
                lbltotal.Text = num1 + " Es mayor " ;

            }

            if (num2 < num1)
            {
                lbltotal.Text = num2 + " Es menor  ";
            }

            else 
            {
                lbltotal.Text = "Son iguales";
            }

        }
    }
}
