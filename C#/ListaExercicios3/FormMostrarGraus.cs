using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaExercicios3
{
    public partial class FormMostrarGraus : Form
    {
        public FormMostrarGraus()
        {
            InitializeComponent();

            double f = 50;

            while (f <= 65)
            {
                double c = (f - 32) * 5 / 9;
                textBoxGraus.Text += (f + "°F " );
                textBoxGrausC.Text += (Math.Round(c, 2) + "°C ");
                    //+ "  " + " Celsius:" + Math.Round(c, 2) + "°"); ; 
                f = f + 1;
                textBoxGraus.ReadOnly = true;
                textBoxGrausC.ReadOnly = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
