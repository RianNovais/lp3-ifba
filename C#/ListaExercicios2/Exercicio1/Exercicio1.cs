using System;
using System.Text;

namespace Exercicio1
{

    internal class Exercicio1{
        static void Main(string[] args)
        {
            //CRIE UM PROGRAMA QUE CALCULE O FATORIAL DE UM NUMERO


            Console.WriteLine("Informe um valor para ser calculado o fatorial: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fat = 1;
            for (int i = 2; i <= n; i++)
            { //CONTADOR INICIANDO COM 1, ENQUANTO O I FOR MENOR QUE O NUMERO INFORMADO, O CONTADOR RECEBE +1
                fat = fat * i; //FATORIAL RECEBERÁ O VALOR 1 VEZES O CONTADOR, ISSO SE REPETIRÁ ENQUANTO O CONTADOR FOR MENOR OU IGUAL O NUMERO INFORMADO.

            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("O Fatorial de " + n + " = " + fat);


            Console.ReadKey();


        }

    }

}

