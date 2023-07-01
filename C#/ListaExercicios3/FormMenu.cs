namespace ListaExercicios3
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonFatorial_Click(object sender, EventArgs e){
            FormFatorial FormFat = new FormFatorial();
            FormFat.Show();

        }

        private void buttonMultiplos_Click(object sender, EventArgs e){
            formMultiplos formMut = new formMultiplos();
            formMut.Show();

        }

        private void buttonConversao_Click(object sender, EventArgs e){
            FormConversao formConversao = new FormConversao();
            formConversao.Show();

        }

        private void buttonVotacao_Click(object sender, EventArgs e){
            FormVotacao formVot = new FormVotacao();
            formVot.Show();

        }
    }
}