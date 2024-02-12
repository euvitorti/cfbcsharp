// PROTECTED - SEMELHANTE AO PRIVATE

namespace MembersProtegidos
{
    //CLASSE BASE
    class Veiculo{
        public int VelocidadeAtual;
        
        // RESTRINGE O ACESSO SOMENTE A CLASSE, ACESSO POR MÉTODOS
        private int VelocidadeMaxima;
        
        // PERMITE ACESSO AOS MEMBROS PELA CLASSE DERIVADA, ACESSO POR MÉTODOS
        protected bool Ligado;

        //CONSTRUTOR
        public Veiculo(int velocidademaxima){
            VelocidadeAtual = 0;
            this.VelocidadeMaxima = velocidademaxima;
            Ligado = false;
        }

        public bool GetLigado(){
            return Ligado;
        }

        public int GetVelocidadeMaxima(){
            return VelocidadeMaxima;
        }
    }

    // CLASSE DERIVADA
    class Carro:Veiculo{
        public string Nome;
        
        // O VALOR DA BASE() -> VAI PARA this.VelocidadeMaxima = velocidademaxima;
        public Carro(string nome, int velocidademaximacarro):base(velocidademaximacarro){
            this.Nome = nome;
            Ligado = true;
        }
    }

    class Program
    {
        static void Main(){
            
            Carro Car = new Carro("BONITÃO", 120);
        
            Console.WriteLine($"NOME: {Car.Nome}");
            Console.WriteLine($"VELOCIDADE MÁXIMA: {Car.GetVelocidadeMaxima()}");
            Console.WriteLine($"LIGADO: {Car.GetLigado()}");
        }
    }
}