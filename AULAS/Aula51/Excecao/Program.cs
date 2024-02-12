// TODA EXCEÇÃO É DERIVADA DA CLASSE exception 

namespace Excecao
{
    class Area
    {
        public static float AreaQuadrado(float baseArea, float altura)
        {
            if (baseArea == 0 || altura == 0)
            {
                throw new Exception("O VALOR NÃO PODE SER ZERO");
            }

            return baseArea * altura;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Clear();

            float area = 0;

            try
            {
                area = Area.AreaQuadrado(6f, 5f);
                Console.WriteLine($"Área do quadrado: {area}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
                Console.WriteLine($"ERROR: {e.GetType()}");
            }
            finally
            {
                // EXCEÇÃO COM finally - VAI SER EXECUTADO COM OU SEM EXCEÇÃO
                Console.WriteLine("FIM DO PROGRAMA");
            }
        }
    }
}