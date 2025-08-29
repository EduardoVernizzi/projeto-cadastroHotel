// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Text;
using trilha_net_explorando_desafio.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();
Suite suite = new Suite();

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

int escolha = 0;

while (true)
{
  Console.WriteLine("Bem vindo ao sistema do Maceió Mar Resort!");
  Console.WriteLine("Escolha uma opção: ");
  Console.WriteLine("1 - Fazer Reserva ");
  Console.WriteLine("2 - Cadastrar Suíte ");
  Console.WriteLine("3 - Encerrar Sistema ");
  escolha = Convert.ToInt32(Console.ReadLine());

  switch (escolha)
  {
    case 1:

      if (suite == null || suite.Capacidade == 0)
      {
        Console.WriteLine("Nenhuma suíte cadastrada! Cadastre primeiro (opção 2).");
        Console.ReadKey();
        Console.Clear();
        break;
      }

      Console.Clear();
      int contador = 0;
      Console.WriteLine("Digite a quantidade de hóspedes: ");
      contador = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Digite a quantidade de dias: ");
      int dias = Convert.ToInt32(Console.ReadLine());
      

      hospedes.Clear();

      for (int i = 0; i < contador; i++)
      {
        Pessoa pessoa = new Pessoa();

        Console.WriteLine($"Digite o nome do hóspede {i + 1}: ");
        pessoa.Nome = Console.ReadLine();

        hospedes.Add(pessoa);
      }

      Reserva reserva = new Reserva(diasReservados: dias);
      reserva.CadastrarSuite(suite);
      reserva.CadastrarHospedes(hospedes);

      Console.Clear();

      Console.WriteLine("Sejam muito bem vindos:");
      foreach (var h in hospedes)
      {
        Console.WriteLine($"Sr(a) {h.Nome}");
      }
      Console.WriteLine($"Valor da hospedagem: {reserva.CalcularValorDiaria().ToString("c")}");
      Console.WriteLine($"Uma excelente estadia em nossa suíte {suite.TipoSuite}");

      Console.ReadKey();
      Console.Clear();
      break;

    case 2:
      Console.Clear();

      suite.Capacidade = 0;

      Console.WriteLine("Qual o tipo da suite?");
      suite.TipoSuite = Console.ReadLine();

      Console.WriteLine("Qual a capacidade?");
      suite.Capacidade = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Qual o valor da diária dessa suíte?");
      suite.ValorDiaria = Convert.ToDecimal(Console.ReadLine());
      Console.Clear();


      break;

    case 3:
      Console.Clear();
      Console.WriteLine("Encerrando sistema...");
      return;


    default:
      Console.WriteLine("Digite uma opção válida!");

      break;
  }
}








