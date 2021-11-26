﻿// See https://aka.ms/new-console-template for more information
using System;

namespace desafio05
{
    public class Program
    {
        public static void Main(string[] args)

        double valorHora = 0;

      try
           {
             Console.WriteLine("Digiti o seu valor de hora")
             valorHora = Convert.ToDouble(Console.ReadLine())
             
           }
           catch (Exception ex)
           {
              Console.WriteLine($"ERRO: {ex.Message}");
           }

        {
          Console.WriteLine("Digiti a valor de horas trabalhadas no mes");
          int quantidadeHoras = Convert.ToInt32(Console.ReadLine());
          double salarioBruto = valorHora * quantidadeHoras;
          double descontoSindicato = salarioBruto * 0.03;
          double descontoInss = salarioBruto * 0.11;
          double fgts = salarioBruto * 0.08;
          double descontoIR = 0;
          double percentualDescontoIR = 0;
          double descontoINSS = 0;

          if (salarioBruto > 2000 && salarioBruto <= 5000)
           percentualDescontoIR = 0.05;
           else if (salarioBruto <= 7500)
           percentualDescontoIR = 0.1;
           else if (salarioBruto > 7500) percentualDescontoIR = 0.2;
           if (percentualDescontoIR != 0)
               descontoIR = salarioBruto * percentualDescontoIR;
          
          double salarioLiquido = salarioBruto - descontoSindicato - descontoINSS - descontoIR;
           Console.WriteLine($"(-) SINDICATO (3%) : {string.Format("{0:0.00}", descontoSindicato)}\n" +
           $"(-) SINDICATO (3%) : {string.Format("{0:0.00}", descontoSindicato)}\n" +
           $"(-) INSS (11%) : {string.Format("{0:0.00}", descontoINSS)}\n"+
           $"(-) IR({percentualDescontoIR * 100}%) :{string.Format("{0:0.00}",descontoIR)}\n" +
           $"(-)FGTS (8%) :{string.Format("{0:0.00}", fgts)}\n"+
           $"Salario Liquido : {string.Format("{0:0.00}",salarioLiquido)}");
      }
    }
}

