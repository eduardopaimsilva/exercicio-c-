using System;

namespace ProgramaOrientacaoOjeto.Cadastros
{
    public class Pessoa
    {
        
        {
          public int Codigo { get; set; }
          
          public string? Name { get; set; }
          
          public string? Sobrenome { get; set; }
          
          
          public DateTime DataNascimento { get; set; }
          
          
          public Pessoa()
          {
            
          }
          public Pessoa(string nome, string sobrenome, DateTime dataNascimento)
          {
            this.Name = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;

          }

          public string CalculaIdade()
          {
            int anos = DateTime.Now.Year - this.DataNascimento.Year;
          if(this.DataNascimento.Month > DateTime.Now.Month)

          anos--;
          return $"{this.nome}tem {anos} anos de idade.";

          }
    }
}