//GET E SET - NÃO É OBRIGADO A IMPLEMENTAR UM GET E UM SET

using System.Security.Cryptography.X509Certificates;

namespace Acessores
{

    class Carro
    {
        private int VelocidadeMaxima;

        public int Velocidade
        {
            get
            {
                return VelocidadeMaxima;
            }
            set
            {
                if (value < 0)
                {
                    VelocidadeMaxima = 0;
                }
                else if (VelocidadeMaxima > 100)
                {
                    VelocidadeMaxima = 100;
                }
                else
                {
                    VelocidadeMaxima = value;
                }
            }
        }

        public Carro()
        {
            Velocidade = 120;
        }
    }

    class Program
    {
        static void Main()
        {
            Carro Combate = new Carro();

            // AQUI USA O GET, ESTÁ LENDO
            Console.WriteLine($"Velocidade: {Combate.Velocidade}");

            //NESTE USA O SET, ENVIANDO A INFORMAÇÃO
            Combate.Velocidade = 50;
            Console.WriteLine($"Velocidade: {Combate.Velocidade}");
        }
    }
}