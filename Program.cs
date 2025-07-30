using DesafioEstacionamentoFromScratch.Models;

Console.WriteLine("\n\nBem vindo ao sistema de estacionamento!");

Console.WriteLine("\n\nDigite o preço inicial:");
decimal initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\nAgora digite o preço que será cobrado por hora:");
decimal pricePerHour = Convert.ToDecimal(Console.ReadLine());


Estacionamento es = new Estacionamento(initialPrice, pricePerHour);

bool showingMenu = true;

while (showingMenu)
{
  Console.Clear();

  Console.WriteLine("Digite um número que corresponde sua opção:");
  Console.WriteLine("1 - Cadastrar veículo");
  Console.WriteLine("2 - Remover veículo");
  Console.WriteLine("3 - Listar veículos");
  Console.WriteLine("4 - Encerrar");

  switch (Console.ReadLine())
  {
    case "1":
      es.AddVeiculo();
      break;

    case "2":
      es.RemoveVeiculo();
      break;

    case "3":
      es.ListaVeiculosRegistrados();
      break;

    case "4":
      showingMenu = false;
      break;

    default:
      Console.WriteLine("Número de menu inválido.");
      break;
  }

  Console.WriteLine("\nPressione uma tecla para continuar");
  Console.ReadLine();
  Console.WriteLine("Sistema encerrado. Até mais :)\n");
}


