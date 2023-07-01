using System;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;


namespace Ex3;

internal class Exercicio3{
    /*A conversão de graus Fahrenheit para Centigrados é obtida por c = 5/9*(f-32). Faça
    um programa que calcule e escreva uma tabela de graus Centigrados e graus
    Fahrenheit, que variam de 50 F a 65 F de 1 em 1.*/

    static void Main(String[] args){
        double f = 50;
        
        while(f <= 65){
            double c = (f - 32) * 5 / 9;
            Console.WriteLine(" Fahrenheit: " + f + "°" + "  " +   " Celsius:" + Math.Round(c,2) + "°");
            f = f + 1;
        }

        Console.ReadKey();
     
    }

}

