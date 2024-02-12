//ARGUMENTO OUT/RETORNA MAIS DE UM VALOR

namespace Aula25
{
    class Program
    {
        static void Main(){
            int NumeroDividendo, NumeroDivisor, NumeroQuociente, RestoDivisao;
            NumeroDividendo = 10;
            NumeroDivisor = 3;
            NumeroQuociente = Divisao(NumeroDividendo, NumeroDivisor, out RestoDivisao);

            Console.WriteLine("{0} / {1}: Quociente = {2} e Resto = {3}",NumeroDividendo, NumeroDivisor, NumeroQuociente, RestoDivisao);
        }
        static int Divisao(int Dividendo, int Divisor, out int Resto){
            int Quociente;
            Quociente = Dividendo / Divisor;
            Resto = Dividendo % Divisor;
            return Quociente;
        }
    }
}