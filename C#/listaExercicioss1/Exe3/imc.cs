using System;

using System.Text;
using System.Threading.Tasks;

namespace Exe3
{
    internal class imc

    {
        static void Main(string[] args)
        {
            //CALCULE O IMC DE UMA PESSOA.
            Console.WriteLine("Qual seu peso em KGs ? ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual sua altura ? ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("SEU IMC É : " + Math.Round(imc, 1));
            Console.WriteLine("------------------------------------");

            if (imc < 18.5)
            {
                Console.WriteLine("MAGREZA");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("PESO NORMAL");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("SOBREPESO");
            }
            else if (imc < 39.9)
            {
                Console.WriteLine("OBESIDADE");
            }
            else
            {
                Console.WriteLine("OBESIDADE GRAVE");
            }

            Console.ReadKey();
        }
    }
}
