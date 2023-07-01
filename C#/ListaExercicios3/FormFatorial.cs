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
    public partial class FormFatorial : Form
    {
        public FormFatorial()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e){
            try{
                int n = Convert.ToInt32(BoxNFat.Text);
                int fat = 1;
                for (int i = 1; i <= n; i++)
                {
                    fat = fat * i;

                }
                MessageBox.Show("O fatorial de " + n + " é :" + fat);

            }catch(Exception ex){
                MessageBox.Show("ERRO DIGITE UM NUMERO VÁLIDO !");
            }
            

        }
    }
}
