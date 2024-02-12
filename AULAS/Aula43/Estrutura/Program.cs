// STRUCT
// PODE GUARDAR VÁRIOS VALORES, OS MEMBROS SÃO ACESSADOS DIRETAMENTE, NÃO É CLASSE, ENTÃO NÃO TEM AS SUA PROPRIEDADES - PODE USAR CONSTRUTORES

namespace Estrutura
{

    struct Carro
    {
        public string marca;
        public string modelo;
        public string cor;

        public Carro(string marca, string modelo, string cor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }
    }

    class Program
    {
        static void Main()
        {
            Carro corrida;
            corrida.marca = "FERRARI";
            corrida.modelo = "Lamborghin";
            corrida.cor = "VERMELHO";

            Console.WriteLine($"MARCA: {corrida.marca}");
            Console.WriteLine($"MODELO: {corrida.modelo}");
            Console.WriteLine($"COR: {corrida.cor}");
        }
    }
}