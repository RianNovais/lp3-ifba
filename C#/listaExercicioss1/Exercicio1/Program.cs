using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
        //EXERCICIO, CALCULE A MÉDIA DE 3 IDADE
        //RIAN MUNIZ 4TIB IFBA CAMAÇARI
    {
        static void Main(string[] args){
            int idadeJoao = 10;
            int idadeMaria = 10;
            int idadeClaudio = 66;

            int media = ((idadeJoao + idadeMaria + idadeClaudio) / 3);

            Console.WriteLine("A média das idades de João, Maria e Cláudio é : " + media);

            Console.ReadKey();
        }
    }
}
