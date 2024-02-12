// É UM RECURSO DA POO, QUANDO UMA CLASSE FILHA HERDA MEMBROS DA CLASSE PAI E JUNTA COM OS SEUS PROPRIOS MEMBROS(BASE)

namespace Heranca
{
    //CLASSE BASE
    class Veiculo{

        public int Rodas;
        public int VelocidadeMaxima;
        private bool Ligado;
        public void Ligar(){
            Ligado = true;
        }
        public void Desligar(){
            Ligado = false;
        }

        public string GetLigado(){
            if (Ligado){
                return "LIGADO";
            } else{
                return "DESLIGADO";
            }
        }
    }

    //CLASSE DERIVADA
    class Carro:Veiculo{

        public string Nome;
        public string Cor;
        public Carro(string nome, string cor){
            Desligar();
            Rodas = 4;
            VelocidadeMaxima = 120;
            this.Nome = nome;
            this.Cor = cor;
        }
    }

    class Program
    {
        static void Main(){
            Carro PrimeiroCarro = new Carro("RAPIDÃO", "VERMELHO");

            Console.WriteLine($"NOME: {PrimeiroCarro.Nome}");
            Console.WriteLine($"COR: {PrimeiroCarro.Cor}");
            Console.WriteLine($"RODAS: {PrimeiroCarro.Rodas}");
            Console.WriteLine($"VELOCIDADE: {PrimeiroCarro.VelocidadeMaxima}");
            Console.WriteLine($"ESTADO: {PrimeiroCarro.GetLigado()}");
        }
    }
}