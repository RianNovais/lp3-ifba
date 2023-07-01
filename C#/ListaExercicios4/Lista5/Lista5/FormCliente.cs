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

namespace Lista5
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCadastroCliente_Click(object sender, EventArgs e)
        {
            StreamWriter cliente = new StreamWriter("C:\\Users\\Maste\\OneDrive\\Área de Trabalho\\LP3\\ListaExercicios4\\IFBACliente\\cliente.txt");
            cliente.WriteLine("Nome: " + textBoxNomeCliente.Text + "\nTelefone: " + textBoxTelefoneCliente.Text + "\nIdade: " + textBoxIdadeCliente.Text);
            cliente.Close();
            textBoxNomeCliente.Clear();
            textBoxIdadeCliente.Clear();
            textBoxTelefoneCliente.Clear();

        }
    }
}
