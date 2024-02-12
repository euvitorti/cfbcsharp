// CLASSE DE REFERÊNCIA SERVE COMO BASE PARA AS OUTRAS CLASSES QUE VÃO HERDAR ELA, NÃO IMPLEMENTA OS MÉTODOS

using System;

namespace Abstratos{
    
    // CLASSE ABSTRATA / BASE
    abstract class Veiculo{

        protected int VelocidadeMaxima;
        protected int VelocidadeAtual;
        protected bool Ligado;

        //CONSTRUTOR
        public Veiculo(){
            Ligado = false;
            VelocidadeAtual = 0;
        }

        // MÉTODO PARA LIGAR O VEÍCULO
        public void SetLigado(bool ligado){
            this.Ligado = ligado;
        }

        public int GetVelocidadeAtual(){
            return VelocidadeAtual;
        }

        // MÉTODO ABSTRACT - NÃO DECLARAR O CORPO!!!! | ESSA MERDA AQUI {}!!!!!!|
        abstract public void Aceleracao(int aceleracao);
    }

    class Carro:Veiculo{
        
        public Carro(){
            VelocidadeMaxima = 120;
        }

        override public void Aceleracao(int aceleracao){
            VelocidadeAtual += aceleracao;
        }
    }

    class Program
    {
        static void Main(){
            
            // NÃO PODE INSTANCIAR OBJETOS EM CLASSE ABSTRATA
            // Veiculo carro = new Veiculo();

            Carro Ferrari = new Carro();

            Ferrari.Aceleracao(1);

            Console.WriteLine($"VELOCIDADE ATUAL: {Ferrari.GetVelocidadeAtual()}");
        }
    }
}