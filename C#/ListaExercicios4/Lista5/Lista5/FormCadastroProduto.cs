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

namespace Lista4
{
    public partial class FormCProduto : Form
    {
        public FormCProduto()
        {
            InitializeComponent();
        }

        private void btCadastroProd_Click(object sender, EventArgs e)
        {
            StreamWriter cliente = new StreamWriter("C:\\Users\\Maste\\OneDrive\\Área de Trabalho\\LP3\\ListaExercicios4\\IFBAProduto\\produtos.txt");
            cliente.WriteLine("Descrição: " + txtBoxDescricao.Text + "\nPreço: R$" + txtBoxPreco.Text + "\nQuantidade no Estoque : " + txtBoxEstoque.Text + "\nData de Validade : " + dtValidade.Text);
            cliente.Close();
            txtBoxDescricao.Clear();
            txtBoxEstoque.Clear();
            txtBoxPreco.Clear();


           
        }
    }
}
