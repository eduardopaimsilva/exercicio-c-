using System;

namespace Exercicio3
{
    public class Program
    {
        public static void Main(string[] args)
      {
         Console.WriteLine("qual preço primeiro produto: ");
          string? texpreco1 = Console.ReadLine();
          Console.WriteLine("qual preço segundo produto: ");
          string? texpreco2 = Console.ReadLine();
          Console.WriteLine("qual preço terceiro produto ");
          string? texpreco3 = Console.ReadLine();
          double preco1 = Convert.ToDouble(texpreco1);
          double preco2 = Convert.ToDouble(texpreco2);
          double preco3 = Convert.ToDouble(texpreco3);

        if (preco1 < preco2 && preco1 < preco3)
        {
          Console.WriteLine("voce deve compra produto1 ");
        }
        else if (preco2 < preco3)
        {
          Console.WriteLine("voce deve compra produto2 ");
        }
        else 
        {
          Console.WriteLine("voce de compra produto3");
        }

      }

    }
}