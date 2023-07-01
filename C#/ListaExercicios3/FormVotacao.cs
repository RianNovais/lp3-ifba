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
    public partial class FormVotacao : Form
    {
        int voto1 = 0;
        int voto2 = 0;
        int voto3 = 0;
        int voto4 = 0;
        int votoB = 0;
        int votoN = 0;
        int totalV = 0;
        double porcB = 0;
        double porcN = 0;

        public FormVotacao()
        {
            InitializeComponent();
        }
        private void btJair_Click(object sender, EventArgs e){
            voto1 += 1;

        }

        private void btLula_Click(object sender, EventArgs e){
            voto2 += 1;

        }

        private void btCiro_Click(object sender, EventArgs e){
            voto3 += 1;

        }

        private void btSimone_Click(object sender, EventArgs e){
            voto4 += 1;

        }
        private void btBranco_Click(object sender, EventArgs e){
            votoB += 1;

        }

        private void btNulo_Click(object sender, EventArgs e) {
            votoN += 1;

        }
            private void btFinalizar_Click(object sender, EventArgs e){
            FormResultadoVot formRes = new FormResultadoVot(voto1, voto2, voto3, voto4, votoB, votoN, totalV, porcB, porcN); //);
            this.Close();
            formRes.Show();


        }

        

        }
}

