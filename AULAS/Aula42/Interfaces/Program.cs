// SÓ IMPLEMENTAM METÓDOS OU OS PROTÓTIPOS - UMA CLASSE PODE HERDAR MAIS DE UMA

namespace Interfaces
{

    // Interface
    public interface Veiculo
    {
        void ligar();
        void desligar();
        void info();
    }


    public interface Combate
    {
        void disparar();
    }

    class Carro : Veiculo, Combate
    {
        public bool ligado;
        public int municao;

        public Carro()
        {
            this.municao = 100;
        }

        public void ligar()
        {
            this.ligado = true;
        }

        public void desligar()
        {
            this.ligado = false;
        }

        public void disparar(){}

        public void info() { }
    }

    class Program
    {
        static void Main()
        {
            Carro Ferrari = new Carro();
            Console.WriteLine($"{Ferrari.municao}");
        }
    }
}