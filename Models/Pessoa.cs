using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_explorando_desafio.Models
{
  public class Pessoa
  {
    public Pessoa() { }
    public Pessoa(string nome, string sobrenome)
    {
      Nome = nome;
      Sobrenome = sobrenome;
    }
    public Pessoa(string nome)
    {
      Nome = nome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

  }
}