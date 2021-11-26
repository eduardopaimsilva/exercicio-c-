using System;
using System.Collections.Generic;


namespace Exercicio07
{
    public class Program
    {
        public static void Main(string[] args)
        {
          for(int i =0; i <10; i++)
           Console.WriteLine($"o valor de i e: {i}");


           //while (true)
           //Console.WriteLine("mensagem de loop infinito");

           int contador =0;
           while (contador < 5)
           {
             Console.WriteLine($"o contador do WHILE e:{contador}");
             contador++;   
           }
           do{
               Console.WriteLine($"O contdor DO WHILE e: {contador}");
               contador++;
           } while (contador < 10);

           List<string> listaNomes = new()
           listaNomes.Add("Paulo Ponciano");
           listaNomes.Add("Eduardo Paim");
           foreach (string nome in listaNomes)
           Console.WriteLine($"nome lista e {nome}");

           try
           {
             Console.WriteLine("Digiti um numero");
             int numero = Convert.ToInt32(ConsoleReadLine());
             
           }
           catch (Exception ex)
           {
              Console.WriteLine($"ERRO: {ex.Message}");
           }

        }
    }
}