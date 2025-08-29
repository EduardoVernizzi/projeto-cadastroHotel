using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_explorando_desafio.Models
{
  public class Reserva
  {
    public Reserva(int diasReservados)
    {
      DiasReservados = diasReservados;
    }


    public List<Pessoa> Hospedes { get; set; }
    public int DiasReservados { get; set; }
    public Suite Suite { get; set; }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
      if (Suite == null)
      {
        throw new Exception("Nenhuma suíte foi associada à reserva!");
      }

      bool acomodaTodos = (Suite.Capacidade >= hospedes.Count());

      if (acomodaTodos)
      {
        Hospedes = hospedes;
      }
      else
      {
        throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte!");
      }

    }
    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      return Hospedes.Count;
    }

    public Decimal CalcularValorDiaria()
    {
      decimal total = DiasReservados * Suite.ValorDiaria;

      if (DiasReservados >= 10)
      {
        return total * 0.90m;
      }
      else
      {
        return total;
      }
    }


  }
}