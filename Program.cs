using DesafioEstacionamentoFromScratch.Models;

Console.WriteLine("\n\nBem vindo ao sistema de estacionamento!");

Console.WriteLine("\n\nDigite o preço inicial:");
decimal initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\nAgora digite o preço que será cobrado por hora:");
decimal pricePerHour = Convert.ToDecimal(Console.ReadLine());


// Estacionamento es = new Estacionamento(initialPrice, pricePerHour);

bool showingMenu = true;

while (showingMenu)
{
  Console.Clear();
  Console.WriteLine("Digite um número correspondente ao que deseja fazer:");

  if (showingMenu)
  {
    switch (Console.ReadLine())
    {
      case "1":

        break;
      case "2":

        break;
      case "3":

        break;
      case "4":
        showingMenu = false;
        break;

      default:
        Console.WriteLine("Número de menu inválido.");
        break;
    }

    Console.ReadLine();
  }
  else
  {
    Console.WriteLine("Sistema encerrado. Até mais :)");
  }
}


