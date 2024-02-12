// PASSAR, LER E USAR DA MANEIRA QUE QUISERMOS
//  dotnet run [ARGS] - PODE FAZER O QUE QUISER, SOMA, TEXTO, ETC!


namespace ArgumentosDeEntrada
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"QUANTIDADES DE ARGUMENTOS: {args.Length}");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"ARGUMENTO {i}: {args[i]}");
                }
            }
            else
            {
                Console.WriteLine("NÃO FORAM PASSADOS ARGUMENTOS");
            }
        }
    }
}