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
           
           Pessoa novoObjetoPessoa = new("maria", "Silva", new DateTime(1980, 10, 25));
           Console.WriteLine($"O nome da pessoa do novo objeto e {novoObjetoPessoa.nome} {novoObjetoPessoa.Sobrenome}. {novoObjetoPessoa.CalculaIdade()}");
        }
    }
}