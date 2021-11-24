using System;

namespace Exercicio06
{
    public class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("Digiti um numero para dia da semana(1 a 7)");
          int diaDaSemana = Convert.ToInt32(Console.ReadLine());

          switch (diaDaSemana)
          {
            case 1:
            Console.WriteLine("domingo");
            break;
            case 2:
            Console.WriteLine("segunda");
            break;
            case 3:
            Console.WriteLine("terça");
            break;
            case 4:
            Console.WriteLine("quarta feira");
            break;
            case 5:
            Console.WriteLine("quinta feira");
            break;
            case 6:
            Console.WriteLine("fexta feira");
            break;
            case 7:
            Console.WriteLine("fexta feira");
            break;
            default:
            Console.WriteLine("numero de 1 a 7");
              break;
          }
          

        }
    }
}
