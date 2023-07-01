using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioTeste
{
    public partial class FormUsuario : Form
    {
        private string login;
        private string senha;
        private string status;
        private string tipo;
        private string data;
        private string perfil;
        private string obs;
        private string modulos;

       

        public FormUsuario(string login, string senha, string status, string tipo, string data, string perfil, string obs, string modulos)
        {
            InitializeComponent();
            this.login = login;
            this.senha = senha;
            this.status = status;
            this.data = data;
            this.tipo = tipo;
            this.obs = obs;
            this.modulos = modulos;
            this.perfil = perfil;

            labelLogin.Text = login;
            labelSenha.Text = senha;
            labelStatus.Text = status;
            labelTipo.Text = tipo;
            labelData.Text = data;
            labelPerfil.Text = perfil;
            labelModulos.Text = modulos;
            labelObs.Text = obs;



        }

        private void labelTipo_Click(object sender, EventArgs e)
        {

        }
    }
    
}
