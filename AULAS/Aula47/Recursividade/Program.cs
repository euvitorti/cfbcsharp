// FUNÇÃO QUE CHAMA ELA MESMA

namespace Recursividade
{
    class Calculo
    {
        public double Soma(params double[] n)
        {
            double somar = 0;
            for (int i = 0; i < n.Length; i++)
            {
                somar += n[i];
            }
            return somar;
        }

        public int Fatorial(int numero)
        {
            int resultado;

            if (numero <= 1)
            {
                resultado = 1;
            }
            else
            {
                resultado = numero * Fatorial(numero - 1);
            }
            return resultado;
        }
    }


    class Program
    {
        static void Main()
        {
            double res;

            Calculo Calcular = new Calculo();

            res = Calcular.Fatorial(10);

            Console.Clear();
            Console.WriteLine(res);
        }
    }
}