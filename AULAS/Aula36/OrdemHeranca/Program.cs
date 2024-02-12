namespace OrdemHeranca
{
    class Base{
        public Base(){
            Console.WriteLine("CONSTRUTOR DA CLASSE BASE.");
        }
    }

    class Derivada:Base{
        public Derivada(){
            Console.WriteLine("CONSTRUTOR DA CLASSE DERIVADA 1.");
        }
    }

    class SegundaDerivada:Derivada{
        public SegundaDerivada(){
            Console.WriteLine("CONSTRUTOR DA CLASSE DERIVADA 2.");
        }
    }
 
    class Program
    {
        static void Main(){
            
            Console.WriteLine("ORDEM DA CHAMADA");
            SegundaDerivada Derivada2 = new SegundaDerivada();
        }
    }
}