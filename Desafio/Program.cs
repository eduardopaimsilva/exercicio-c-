﻿
using System;

namespace Desafio
{
    public class Program
    {
        public static void Main(string[] args)

         {
           double salario = 0;
  
           try
           {
            Console.WriteLine("digiti o salario: ");
            salario = Convert.ToDouble(Console.ReadLine());
             
           }
           catch (Exception ex)
           {
              Console.WriteLine($"ERRO: {ex.Message}");
           }


        if (salario < 2000)
        {
            salario = salario * 0.2;
           Console.WriteLine("O Produto 01 deve ser comprado "+salario);
        }
        else if (salario >= 7000 && salario < 15000)
        {
          salario = salario * 0.20;
          Console.WriteLine("O salario com 20% de aumento  "+salario);
        }
        else if (salario >= 7000 && salario < 15000)
        {
        salario = salario* 0.15;
        Console.WriteLine("O salario com 15% de aumento "+salario);

        }
        else
        {
        salario = salario * 0.05;
        Console.WriteLine("O salario com 5% de aumento "+ salario);


        }
    }
}

