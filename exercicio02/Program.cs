using System;
namespace Exercicio01
{
    public class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("Digite o primeiro numero: ");
          string? numero1 = Console.ReadLine();
          Console.WriteLine("digite o segundo numero: ");
          string? numero2 = Console.ReadLine();
          Console.WriteLine("Digite o terceiro numero ");
          string? numero3 = Console.ReadLine();
          int num01 = Convert.ToInt32(numero1);
          int num02 = Convert.ToInt32(numero2);
          int num03 = Convert.ToInt32(numero3);

          int maior = 0;
          int menor = 0;

          if (num01 > num02)
          {
             if(num01 > num03)
             {
               maior = num01;
             }
             else
             {
                 maior = num03;
                }
             }
             else
             {
                if(num02 > num03)
                {
                  maior = num02;
                }
                else
               {
                 maior = num03;
               }

               //int  = 0;

          if (num01 > num03)
          {
             if(num01 > num03)
             {
               menor = num01;
             }
             else
             {
                 menor = num03;
                }
             }
             else
             {
                if(num02 > num03)
                {
                  maior = num02;
                }
                else
               {
                 menor = num03;
               }

             }
               Console.WriteLine("o maior numero e  "+maior + "O menor  numero e "+ menor);
             }
        }
    }
}