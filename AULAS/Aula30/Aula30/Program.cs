// O QUE É DECLARAÇÃO DE CLASSES STATIC - NÃO PERMITEM INSTANCIAR OBJETOS E NEM CONSTRUTORES

namespace Aula30{
    static public class Jogador{
        static public int Energia;
        static public bool Vivo;
        static public string Nome;
    
        //CONSTRUTOR - DAR INÍCIO AS VARIÁVEIS
        static public void Iniciar(string n){
            Energia = 100;
            Vivo = true;
            Nome = n;
        }

        static public void Informacao(){
            Console.WriteLine("NOME: {0}",Nome);
            Console.WriteLine("ENERGIA: {0}",Energia);
            Console.WriteLine("VIDA: {0}\n",Vivo);
        }
    }

    class Inimigo{
        static public bool alerta;
        public string nomeInimigo;
        public Inimigo(string inimigoNome){
            alerta = false;
            nomeInimigo = inimigoNome;
        }

        public void informacaoInimigo(){
            Console.WriteLine(nomeInimigo
            );
            Console.WriteLine(alerta);
            Console.WriteLine("");
        }
    }


    public class Program
    {
        static void Main(){
            
            Jogador.Iniciar("VITOR");
            Jogador.Informacao();

            Console.WriteLine("");

            Inimigo inimigo1 = new Inimigo("DOIDO");
            Inimigo inimigo2 = new Inimigo("MALUCO");
            Inimigo inimigo3 = new Inimigo("PIRADO");
            
            Inimigo.alerta = true;

            inimigo1.informacaoInimigo();
            inimigo2.informacaoInimigo();
            inimigo3.informacaoInimigo();

            Console.WriteLine("FIM");
        }
    }
}