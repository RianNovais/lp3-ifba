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
    public partial class FormConversao : Form
    {
        public FormConversao()
        {
            InitializeComponent();
        }

        private void btMostrarGraus_Click(object sender, EventArgs e){
            FormMostrarGraus formMostrarGraus = new FormMostrarGraus();
            formMostrarGraus.Show();
            this.Close();

        }
    }
}
