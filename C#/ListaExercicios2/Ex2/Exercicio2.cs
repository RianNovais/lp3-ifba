using System;
using System.Text;

namespace Ex2;

internal class Exercicio2{
    /*Escreva um algoritmo que informe todos os múltiplos de 17 ou de 31 compreendidos
        no intervalo entre 500 e 1000.*/

    static void Main(String[] args){

        int a;
        int b;

        for (a = 500; a <=1000; a++)
            if(a % 17 == 0){
                String x = a.ToString();
                Console.WriteLine("Multiplo de 17: " + a);
            }
        for (b = 500; b <=1000; b++){
            if(b % 31 == 0){
                String x = b.ToString();
                Console.WriteLine("Multiplo de 31: " + b);

            }
        }

        Console.ReadKey();
    }

        
    }
        


       

    
        

   
        

    

        
  