namespace DesafioEstacionamentoFromScratch.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }


        public void AddVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo");
            string placa = Console.ReadLine().ToUpper();
            veiculos.Add(placa);
        }

        public void ListaVeiculosRegistrados()
        {
            Console.Clear();
            if (veiculos.Count > 0)
            {
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados :(");
            }
        }

        public void RemoveVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que será removido:");
            string placa = Console.ReadLine().ToUpper();

            if (veiculos.Any(veiculo => veiculo == placa))
            {
                Console.WriteLine("Quantas horas este veículo ficou estacionado?");
                int horasEstacionado = Convert.ToInt32(Console.ReadLine());
                decimal valorTotalEstacionamento = (horasEstacionado * precoPorHora) + precoInicial;

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido, e o custo do estacionamento ficou em R${valorTotalEstacionamento}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado...");
            }
        }

    }
}