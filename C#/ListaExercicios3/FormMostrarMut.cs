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
    public partial class FormMostrarMut : Form
    {
        public FormMostrarMut()
        {
            InitializeComponent();

            int a;
            int b;

            textBoxMut1.Text += ("Multiplos de 17: ");
            for (a = 500; a <= 1000; a++){ 
                if (a % 17 == 0){
                    String x = a.ToString();
                    textBoxMut1.Text += (x + ", ");
                    textBoxMut1.ReadOnly = true;
                }
        }

        textBoxMut2.Text += ("Multiplos de 31:  ");
            for (b = 500; b <= 1000; b++){
                if (b % 31 == 0){
                    String x = b.ToString();
                    textBoxMut2.Text += (x + ", ");
                    textBoxMut2.ReadOnly = true;

                }
            }
        }
    }
}
