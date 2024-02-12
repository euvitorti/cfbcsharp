// É UM RECURSO DA POO, QUANDO UMA CLASSE FILHA HERDA MEMBROS DA CLASSE PAI E JUNTA COM OS SEUS PROPRIOS MEMBROS(BASE)

//CADEIA HERANÇA E CONSTRUTOR DA CLASSE BASE

using System.Runtime.InteropServices;

namespace CadeiaHeranca
{
    //CLASSE BASE
    class Veiculo{

        private int Rodas;
        public int VelocidadeMaxima;
        private bool Ligado;
        
        //CONSTRUTOR
        public Veiculo(int rodas){
            this.Rodas = rodas;
        }

        public void Ligar(){
            Ligado = true;
        }
        public void Desligar(){
            Ligado = false;
        }

        public string GetLigado(){
           
            //OPERADOR TERNÁRIO, [?] É O OPERADOR, SE FOR VERDADE RETORNA A PRIMEIRA SENTENÇA
            return(Ligado?"LIGADO":"DESLIGADO");
            
            // if (Ligado){
            //     return "LIGADO";
            // } else{
            //     return "DESLIGADO";
            // }
        }

        public int GetRodas(){
            return Rodas;
        }

        public void SetRodas(int rodas){
            if(rodas > 0 && rodas < 5){
                this.Rodas = 4;
            }else{
                Console.WriteLine("VALOR INVÁLIDO PARA RODAS");
            }
        }
    }

    //CLASSE DERIVADA
    class Carro:Veiculo{

        public string Nome;
        public string Cor;
        
        //INICIALIZANDO. IR NA BASE DERIVADA, E INICIAR O CONSTRUTOR DA CLASSE BASE
        public Carro(string nome, string cor):base(4){
            Desligar();
            GetRodas();
            VelocidadeMaxima = 120;
            this.Nome = nome;
            this.Cor = cor;
        }
    }

    //CADEIA DE HERANÇA, CLASSE CARROCOMBATE É DERIVADA DA CLASSE CARRO, PARA CARRO COMBATE, CARRO É A CLASSE BASE
    class CarroCombate:Carro{
        public int Municao;
        public CarroCombate():base("STRONG", "PRETO"){
            Municao = 100;
            SetRodas(4);
        }
    }

    class Program
    {
        static void Main(){
            Carro PrimeiroCarro = new Carro("RAPIDÃO", "VERMELHO");
            CarroCombate PrimeiroCarroCombate = new CarroCombate();


            Console.WriteLine($"NOME: {PrimeiroCarro.Nome}");
            Console.WriteLine($"COR: {PrimeiroCarro.Cor}");
            Console.WriteLine($"RODAS: {PrimeiroCarro.GetRodas()}");
            Console.WriteLine($"VELOCIDADE: {PrimeiroCarro.VelocidadeMaxima}");
            Console.WriteLine($"ESTADO: {PrimeiroCarro.GetLigado()}");
        
            Console.WriteLine("");
            Console.WriteLine("CARRO COMBATE");
            Console.WriteLine("");

            Console.WriteLine($"NOME: {PrimeiroCarroCombate.Nome}");
            Console.WriteLine($"COR: {PrimeiroCarroCombate.Cor}");
            Console.WriteLine($"RODAS: {PrimeiroCarroCombate.GetRodas()}");
            Console.WriteLine($"VELOCIDADE: {PrimeiroCarroCombate.VelocidadeMaxima}");
            Console.WriteLine($"ESTADO: {PrimeiroCarroCombate.GetLigado()}");
            Console.WriteLine($"MUNIÇÃO: {PrimeiroCarroCombate.Municao}");
        }
    }
}