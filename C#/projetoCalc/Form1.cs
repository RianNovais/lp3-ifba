//RIAN MUNIZ 4TIB

using System.Runtime.InteropServices.ObjectiveC;

namespace projetoCalc
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelN1_Click(object sender, EventArgs e)
        {}

        private void btSoma_Click(object sender, EventArgs e)
        {
            float n1, n2, r;

            n1 = global::System.Single.Parse(textN1.Text); //CONVERTER STRING EM FLOAT
            n2 = global::System.Single.Parse(textN2.Text);

            r = n1 + n2;

            labelRes.Text = Convert.ToString(r);


        }

        private void btSub_Click(object sender, EventArgs e){
            float n1, n2, r;

            n1 = global::System.Single.Parse(textN1.Text); 
            n2 = global::System.Single.Parse(textN2.Text);


            r = n1 - n2;

            labelRes.Text = Convert.ToString(r);
        }
        private void BtMult_Click(object sender, EventArgs e){
            float n1, n2, r;

            n1 = global::System.Single.Parse(textN1.Text); //CONVERTER STRING EM FLOAT
            n2 = global::System.Single.Parse(textN2.Text);

            r = n1 * n2;

            labelRes.Text = Convert.ToString(r);

        }
        private void btDiv_Click(object sender, EventArgs e){
            float n1, n2, r;

            n1 = global::System.Single.Parse(textN1.Text); //CONVERTER STRING EM FLOAT
            n2 = global::System.Single.Parse(textN2.Text);

            r = n1 / n2;

            labelRes.Text = Convert.ToString(r);


        }

        private void btApagar_Click(object sender, EventArgs e){
            labelRes.Text = ("");

        }

        private void btSair_Click(object sender, EventArgs e){
            Application.Exit();
            Console.WriteLine("Calculadora encerrada !");


        }

        private void Form1_Load(object sender, EventArgs e)
        {}

    }
}