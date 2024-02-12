// 

using SobreCargaMetodos;

namespace SobreCargaMetodos
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
    }


    class Program
    {
        static void Main()
        {
            double res;

            Calculo Calcular = new Calculo();

            res = Calcular.Soma(10, 5, 5.5);

            Console.Clear();
            Console.WriteLine(res);
        }
    }
}