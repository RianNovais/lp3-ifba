using Lista4;
using System.IO;

namespace Lista5
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btEnviarFuncionario_Click(object sender, EventArgs e)
        {
            StreamWriter vendedor = new StreamWriter("C:\\Users\\Maste\\OneDrive\\¡rea de Trabalho\\LP3\\ListaExercicios4\\IFBAVendedor\\cadastro.txt");
            vendedor.WriteLine("Vendedor: " + textBoxVendNome.Text + "\nComiss„o: R$" + textBoxVendComissao.Text + "\n¡rea: " + textBoxVendArea.Text); ;
            vendedor.Close();
            textBoxVendArea.Clear();
            textBoxVendComissao.Clear();
            textBoxVendNome.Clear();
        }

        private void btEnviarSocio_Click(object sender, EventArgs e)
        {
            StreamWriter socio = new StreamWriter("C:\\Users\\Maste\\OneDrive\\¡rea de Trabalho\\LP3\\ListaExercicios4\\IFBASocio\\cadastro.txt");
            socio.WriteLine("Nome: " + textBoxNomeSocio.Text + "\nData de Nascimento: " + dtSocio.Text + "\n¡rea: " + textBoxAreaSocio.Text); ;
            socio.Close();
            textBoxNomeSocio.Clear();
            textBoxAreaSocio.Clear();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e) {
            FormCProduto formCadastrarProduto = new FormCProduto();
            formCadastrarProduto.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}