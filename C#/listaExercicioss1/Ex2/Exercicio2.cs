using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Exercicio2{

        //EXERCICIO 2, CRIE UM PROGRAMA QUE FAÇA A EQUAÇÃO DE BHASKARA, E RETORNE AS RAIZES DE UMA EQUAÇÃO DE 2 GRAU. 
        //RIAN MUNIZ 4TI
        static void Main(string[] args){
            int a, b, c;
            double delta, a1, a2;
            

            Console.WriteLine("Informe o valor do coeficiente A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor do coeficiente B");
            b = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Informe o valor do coeficiente C");
            c = Convert.ToInt32(Console.ReadLine());

            delta = b * b - 4 * a * c;

            Console.WriteLine("-------------------------------------------------------------");

            if (delta < 0) {
                Console.WriteLine("DELTA NEGATIVO, NÃO EXISTEM RAIZES REAIS");
            }
            else{
                a1 = ((-b + Math.Sqrt(delta)) / 2 * a);
                a2 = ((-b - Math.Sqrt(delta)) / 2 * a);

                Console.WriteLine("Delta = " + delta);
                Console.WriteLine("As duas raízes da equação são: " +  Math.Round(a1, 3) + " e " + Math.Round(a2, 3));
            }
            Console.ReadKey();

            
        }
    }
}
