// UMA COLEÇÃO DE DADOS - RELAÇÃO COM CHAVES

namespace Dicionario
{
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Dictionary<int, string> veiculos = new Dictionary<int, string>();

            veiculos.Add(1, "Hyunde");
            veiculos.Add(2, "Honda");
            veiculos.Add(3, "Kia");

            // REMOVENDO UMA CHAVE ESPECÍFICA
            veiculos.Remove(2);

            // COLOCANDO UM VALOR
            veiculos[1] = "HONDA";

            Console.WriteLine($"TAMANHO DO DICTIONARY: {veiculos.Count}");

            // LIMPANDO O DICTIONARY
            // veiculos.Clear();
            // Console.WriteLine($"TAMANHO DO DICTIONARY: {veiculos.Count}");

            if (veiculos.ContainsKey(1))
            {
                Console.WriteLine("CHAVE FOI ACHADA");
            }
            else
            {
                Console.WriteLine("NÃO FOI ENCONTRADA");
            }

            Dictionary<int, string>.ValueCollection valores = veiculos.Values;

            foreach (string valor in valores)
            {
                Console.WriteLine(valor);
            }

            // foreach (KeyValuePair<int, string> valores in veiculos)
            // {
            //     Console.WriteLine(valores);
            // }
        }
    }
}