using System.Linq.Expressions;

namespace FormularioTeste
{
    public partial class Form1 : Form
    {
        String login;
        String senha;
        String status;
        String tipo;
        String data;
        String perfil;
        String obs;
        String modulos;

        List<CheckBox> mod = new List<CheckBox>();
        public Form1()
        {
            
            InitializeComponent();
            mod.Add(cbCompras);
            mod.Add(cbBiblioteca);
            mod.Add(cbAcademico);
            mod.Add(cbDocumentacao);
            mod.Add(cbRH);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //TRATAMENTO DE ERROS: NAO DEIXAR OS CAMPOS COM ESPAÇO OU EM BRANCO
            if (string.IsNullOrEmpty(txtLogin.Text) || (string.IsNullOrEmpty(txtSenha.Text) || (string.IsNullOrEmpty(cbStatus.Text)))){

                MessageBox.Show("NÃO DEIXE CAMPOS EM BRANCO");
            }



            //COLETANDO DADOS DO FORMULARIOS, INSERIDOS NOS TEXTBOX, RADIOBUTTON, COMBOBOX E CHECKBOX.

            login = txtLogin.Text;
            senha = txtSenha.Text;
            status = cbStatus.Text;
            data = dt_Data.Text;
            try{
                tipo = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text; //PEGAR O RADIOBUTTON SELECIONADO
                perfil = groupBox2.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            }
            catch(NullReferenceException){
                MessageBox.Show("ERRO PREENCHA OS BOTÕES ");
                
          
            }
            
            //data = txtData.Text;
            
            obs = txtObs.Text;

            modulos = "";

           //USANDO O FOREACH PARA COLETAR DADOS DO CHECKBOX UTILIZANDO UMA LISTA.

            foreach(CheckBox t in mod){ 
                if (t.Checked){
                    modulos += t.Text + ", ";
                }
            
            }


            FormUsuario formUsuario = new FormUsuario(login, senha, status, tipo, data, perfil, obs, modulos);
            formUsuario.Show();

            //MessageBox.Show(login + " " + senha + " " + status + "" + tipo + "" + data + "" + perfil + " " + modulos);
            
        }

        private void btLimpar_Click(object sender, EventArgs e){

            txtLogin.Clear();
            txtSenha.Clear();
            txtObs.Clear();

            cbStatus.SelectedIndex = -1;
            foreach (CheckBox t in mod)
            {
                if (t.Checked)
                {
                    t.Checked = false;
                }

            }
            groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked = false);
            groupBox2.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked = false);


        }
    }
}