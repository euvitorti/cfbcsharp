// CLASSE SEALED NÃO PODE SER HERDADA E PONTO FINAL! NEM MAIS NEM MENOS!

namespace Selada{
    
    sealed class Veiculo{}

    class Carro:Veiculo{}

    class Program
    {
        static void Main(){

            Carro  Combate = new Carro();
        }
    }
}