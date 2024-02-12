// OBJETO QUE FAZ REFERÊNCIA Á UM MÉTODO


namespace Delegados
{
    delegate int Operacao(int entradaPrimeiroNumero, int entradaSegundoNumero);
    // GLOBAL

    class Math
    {
        public static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Multiplicacao(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }
    }

    class Program
    {
        static void Main()
        {
            int resultado;

            Operacao primeiraOperacao = new Operacao(Math.Soma);
            resultado = primeiraOperacao(10, 50);
            Console.WriteLine($"SOMA: {resultado}");

            primeiraOperacao = new Operacao(Math.Multiplicacao);
            resultado = primeiraOperacao(10, 50);
            Console.WriteLine($"MULTIPLICAÇÃO: {resultado}");
        }
    }
}