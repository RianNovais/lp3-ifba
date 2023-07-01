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
    public partial class FormResultadoVot : Form
    {
        private int voto1;
        private int voto2;
        private int voto3;
        private int voto4;
        private int votoB;
        private int votoN;
        private int totalV;
        private double porcB;
        private double porcN;

   

        public FormResultadoVot(int voto1, int voto2, int voto3, int voto4, int votoB, int votoN, int totalV, double porcB, double porcN)
        {
            this.voto1 = voto1;
            this.voto2 = voto2;
            this.voto3 = voto3;
            this.voto4 = voto4;
            this.votoB = votoB;
            this.votoN = votoN;
            this.totalV = totalV;
            this.porcB = porcB;
            this.porcN = porcN;

            InitializeComponent();

            labelBolsonaro.Text = ("Votos em Bolsonaro: " + voto1);
            labelLula.Text = ("Votos em Lula: " + voto2);
            labelCiro.Text = ("Votos em Ciro: " + voto3);
            labelSimone.Text = ("Votos em Simone: " + voto4);
            labelBranco.Text = ("Votos Brancos: " + votoB);
            labelNulo.Text = ("Votos Nulos: " + votoN);
            totalV = voto1 + voto2 + voto3 + voto4 + votoB + votoN;
            porcB = (Convert.ToDouble(votoB) / Convert.ToDouble(totalV));
            porcN = (Convert.ToDouble(votoN) / Convert.ToDouble(totalV));



            labelPorcB.Text = ("A porcentagem de votos brancos em relação ao total de votos foi: " + Math.Round(porcB * 100, 2) + "%");
            labelPorcN.Text = ("A porcentagem de votos nulos em relação ao total de votos foi: " + Math.Round(porcN * 100, 2) + "%");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


