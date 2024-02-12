// STRUCT
// PODE GUARDAR VÁRIOS VALORES, OS MEMBROS SÃO ACESSADOS DIRETAMENTE, NÃO É CLASSE, ENTÃO NÃO TEM AS SUA PROPRIEDADES - PODE USAR CONSTRUTORES

using System.Security.Cryptography.X509Certificates;

namespace VetorEstrutura
{

    struct Carro
    {
        public string marca;
        public string cor;

        public void Informacao()
        {
            Console.WriteLine($"MARCA: {this.marca}");
            Console.WriteLine($"COR: {this.cor}");
            Console.WriteLine("");
        }
    }

    class Program
    {
        static void Main()
        {
            int[] numeros = new int[2];

            Carro[] corrida = new Carro[2];

            corrida[0].marca = "FERRARI";
            corrida[0].cor = "VERMELHO";
            corrida[1].marca = "BULGATTI";
            corrida[1].cor = "AZUL";

            for (int i = 0; i < corrida.Length; i++)
            {
                corrida[i].Informacao();
            }
        }
    }
}