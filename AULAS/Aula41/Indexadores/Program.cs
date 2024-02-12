// UM MEMBRO DE UMA CLASSE QUE PERMITE AOS OBJETOS SER INDEXADOS COMO ARRAY

namespace Indexadores
{

    class Carro
    {
        private int[] VelocidadeMaxima = new int[5] { 80, 120, 160, 240, 300 };

        public int this[int i]
        {
            get
            {
                return VelocidadeMaxima[i];
            }
            set
            {
                if (value < 0)
                {
                    VelocidadeMaxima[i] = 0;
                }
                else if (VelocidadeMaxima[i] > 100)
                {
                    VelocidadeMaxima[i] = 100;
                }
                else
                {
                    VelocidadeMaxima[i] = value;
                }
            }
        }

        public Carro(){}
    }

    class Program
    {
        static void Main()
        {
            Carro Combate = new Carro();

            // AQUI USA O GET, ESTÁ LENDO
            Console.WriteLine($"Velocidade: {Combate[0]}");

            //NESTE USA O SET, ENVIANDO A INFORMAÇÃO
            Combate[4] = 50;
            Console.WriteLine($"Velocidade: {Combate[4]}");
        }
    }
}