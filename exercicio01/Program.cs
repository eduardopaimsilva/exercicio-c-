using System;

namespace Exercicio01
{
    public class Program
    {
        public static void Main(string[] args)
        {

          Console.WriteLine("Digiti a primeira nota:");
          string? n1 = Console.ReadLine();
          Console.WriteLine("Digiti a segunda nota: ");
          string? n2 = Console.ReadLine();
          double nota01 = Convert.ToDouble(n1);
          double nota02 = Convert.ToDouble(n2);
          double media = (nota01 + nota02)/2;
          if(media == 10)
          {
            Console.WriteLine("Aprovado Distinçao");
          }
          else if (media >=7)
          {
            Console.WriteLine("Aprovado");
          }
          else
          {
             Console.WriteLine("Reprovado");
          }

        }
    }
}
    