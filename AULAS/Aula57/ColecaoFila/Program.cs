// O PRIMEIRO A SER ADICIONADO É O PRIMEIRO A SAIR DA LISTA

namespace ColecaoFila
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            // string[] veiculos = ["HONDA", "HYUNDAY", "KIA"];
            // PODE INICIALIZAR COM UM ARRAY

            Queue<string> veiculos = new Queue<string>();

            veiculos.Enqueue("CARRO");
            veiculos.Enqueue("MOTO");
            veiculos.Enqueue("NAVIO");
            veiculos.Enqueue("AVIÃO");

            string transporte = "BICICLETA";

            if (veiculos.Contains(transporte))
            {
                Console.WriteLine($"{transporte} ESTÁ NO CADASTRO");
            }
            else
            {
                Console.WriteLine($"{transporte} NÃO ESTÁ NO CADASTRO");
            }

            Console.WriteLine("");

            // ELE RETORNA O E TIRA DA FILA
            Console.WriteLine($"PRIMEIRO VEÍCULO: {veiculos.Dequeue()}");

            Console.WriteLine("");

            // RETORNA PORÉM NÃO REMOVE
            // Console.WriteLine($"PRIMEIRO VEÍCULO: {veiculos.Peek()}");

            Console.WriteLine("");

            foreach (string todosVeiculos in veiculos)
            {
                Console.WriteLine($"VEÍCULOS: {todosVeiculos}");
            }

            Console.WriteLine("");

            Console.WriteLine($"TAMANHO DA FILA: {veiculos.Count}");
        }
    }
}