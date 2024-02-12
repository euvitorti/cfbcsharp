// VARIÁVEIS E MÉTODOS STATICS
// QUANDO UAM CLASSE E UTILIZAR OS MÉTODOS SEM DECLARAR OS MÉTODOS DA CLASSE, SÓ DECLARA OS MEMBROS COMO STATIC

namespace MetodosEstaticos
{

    class Math
    {
        // MEMBROS
        public static double pi = 3.14;
        public static int Dobro(int n)
        {
            return n * 2;
        }
    }

    class Program
    {
        static void Main()
        {

            //NÃO PRECISOU DECLARAR - Math valor = new...;

            double valorPi = Math.pi;

            int valor = 10;
            Console.WriteLine(Math.Dobro(valor));
            Console.WriteLine(valorPi);
        }
    }
}