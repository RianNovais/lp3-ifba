using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;

namespace Ex4;

internal class Exercicio4{
    //EXERCICIO VOTAÇÃO EM 4 CANDIDATOS.
    static void Main(String[] args){

        int v1 = 0;
        int v2 = 0;
        int v3 = 0; 
        int v4 = 0;
        int vn = 0;
        int vb = 0;
        int e = 7;

        while (e != 0){
            Console.WriteLine("Qual sua escolha ? , escolha conforme numeros a seguir: 1 - Simone Tebet, 2 - Lula, 3 - Bolsonaro, 4 - Ciro Gomes ");
            Console.WriteLine("5 - Voto Nulo, 6 - Voto Branco");
            e = Convert.ToInt32(Console.ReadLine());

            switch (e)
            {

                case 1:
                    v1 = v1+1;
                    Console.WriteLine("VOTO EM SIMONE TEBET COMPUTADO COM SUCESSO");
                    Console.WriteLine("-------------------------------------------");
                    break;

                case 2:
                    v2 = v2+1;
                    Console.WriteLine("VOTO EM LULA COMPUTADO COM SUCESSO");
                    Console.WriteLine("-------------------------------------------");
                    break;

                case 3:
                    v3 = v3+1;
                    Console.WriteLine("VOTO EM BOLSONARO COMPUTADO COM SUCESSO:");
                    Console.WriteLine("-------------------------------------------");
                    break;

                case 4:
                    v4 = v4+1;
                    Console.WriteLine("VOTO EM CIRO GOMES COMPUTADO COM SUCESSO");
                    Console.WriteLine("-------------------------------------------");
                    break;

                case 5:
                    vn = vn+1;
                    Console.WriteLine("VOTOU NULO");
                    Console.WriteLine("---------------------------------------");
                    break;

                case 6:
                    vb = vb+1;
                    Console.WriteLine("VOTOU EM BRANCO");
                    Console.WriteLine("---------------------------------------");
                    break;

                default:
                    Console.WriteLine("VOTO INVALIDO VOTE NOVAMENTE");
                    Console.WriteLine("------------------------------------------");
                    break;

                case 0:
                    Console.WriteLine("VOTAÇÃO FINALIZADA");
                    Console.WriteLine("-------------------------------------------------");
                    break;



                    
            

            }
            
        }
        int TotalV = v1 + v2 + v3 + v4 + vb + vn;
        double porcB = (Convert.ToDouble(vb) / Convert.ToDouble(TotalV));
        double porcN = (Convert.ToDouble(vn) / Convert.ToDouble(TotalV));
        Console.WriteLine("TOTAL DE VOTOS:" + TotalV +  " \r\n SIMONE TEBET: " + v1 + "\r\n LULA: " + v2 + "\r\n BOLSONARO: " + v3 + "\r\n CIRO GOMES: " + v4 + "\r\n VOTOS BRANCOS: " + vb + "\r\n VOTOS NULOS: " + vn);
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("A Porcentagem de votos brancos em relação ao total de votos foi de " + Math.Round(porcB*100, 2) + "%");
        Console.WriteLine("A Porcentagem de votos nulos em relação ao total de votos foi de " + Math.Round(porcN*100, 2) + "%");



        Console.ReadKey();
    }
           
        

    }

       

     

        


