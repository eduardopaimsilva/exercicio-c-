using System;

using ProgramaOrientacaoOjeto;

namespace EstruturasRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
          Pessoa objetoPessoa = new();
          objetoPessoa.Name = "Paulo";
          objetoPessoa.Sobrenome = "Paim";
          Console.WriteLine($"O nome da pessoa e:{objetoPessoa.Nome} {objetoPesso.Sobrenome}");
           
           Console.WriteLine("Digiti sua data de nascimento(dd/MM/aaaa)");
           string? textoDataNascimento = Console.WriteLine();
           int ano = Convert.ToInt32(textoDataNascimento?.Substring(6, 4));
           int mes = Convert.ToInt32(textoDataNascimento?.Substring(3, 2));
           int di = Convert.ToInt32(textoDataNascimento?.Substring(0, 2));


           Pessoa novoObjetoPessoa = new("maria", "Silva", new DateTime(ano, mes, dia));
           Console.WriteLine($"O nome da pessoa do novo objeto e {novoObjetoPessoa.nome} {novoObjetoPessoa.Sobrenome}. {novoObjetoPessoa.CalculaIdade()}");
        }
    }
}