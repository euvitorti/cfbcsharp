// SÃO MÉTODOS QUE TEM O MESMO NOME EM CLASSES DIFERENTES - UMA CLASSE QUE HERDA OUTRA E TEM UM MÉTODO DA SUA CLASSE BASE - ESSE MÉTODO EXECUTA UMA AÇÃO DIFERENTE - DEFINE NA CLASSE BASE

namespace MetodosVirtuais
{
    class Base{
        public Base(){
            Console.WriteLine("CONSTRUTOR DA CLASSE BASE.");
        }

        // NÃO PRECISA ESCREVER, PQ VAI SER PERDIDO ESTE VALOR,  CADA CLASSE VAI TER UM
        virtual public void Informacao(){}
    }

    class Derivada:Base{
        public Derivada(){
            Console.WriteLine("CONSTRUTOR DA CLASSE DERIVADA 1.");
        }

        override public void Informacao(){
            Console.WriteLine("MÉTODO VIRTUAL 2");
        }
    }

    class SegundaDerivada:Derivada{
        public SegundaDerivada(){
            Console.WriteLine("CONSTRUTOR DA CLASSE DERIVADA 2.");
        }

        override public void Informacao(){
            Console.WriteLine("MÉTODO VIRTUAL 3");
        }
    }
 
    class Program
    {
        static void Main(){
            
            Console.WriteLine("ORDEM DA CHAMADA");

            Base Ref;

            Derivada PrimeiraDerivada = new Derivada();
            SegundaDerivada Derivada2 = new SegundaDerivada();


            Ref = Derivada2;
            Ref.Informacao();
        }
    }
}