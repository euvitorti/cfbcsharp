//CONSTRUTORES E DESCONSTRUTORES, OS DOIS TEM QUE TER O MESMO NOME DA CLASSE

namespace Aula28{
    public class Jogador{
        public int Energia;
        public bool Vivo;
        public string Nome;
    
        //CONSTRUTOR - DAR INÍCIO AS VARIÁVEIS
        public Jogador(string Name){
            Energia = 100;
            Vivo = true;
            Nome = Name;
        }

        // ESSE É O DECONSTRUTOR
        ~Jogador(){
            Console.WriteLine("JOGADOR FOI DESTRUIDO.");
        }
    }

    //QUANDO NÃO USA NENHUM MODIFICADOR A CLASSE É PÚBLICA
    public class Program
    {
        static void Main(){

            string NomeJogador;
            string NomeJogador2;

            Console.WriteLine("DIGITE O NOME DO JOGADOR 1: ");
            NomeJogador = Console.ReadLine();

            Console.WriteLine("DIGITE O NOME DO JOGADOR 2: ");
            NomeJogador2 = Console.ReadLine();        

            //CRIANDO UM OBJETO, USA O OPERADOR NEW, VAI NA MÉMORIA RAM CRIAR UM ESPAÇO PARA ESSE OBJETO
            Jogador Player = new Jogador(NomeJogador);
            Jogador Player2 = new Jogador(NomeJogador2);

            Player.Energia = 50;
            Console.WriteLine("NOME DO JOGADOR 1: {0}", Player.Nome);
            Console.WriteLine("ENERGIA DO JOGADOR {0}: {1}", Player.Nome, Player.Energia);
            Console.WriteLine("NOME DO JOGADOR 2: {0}", Player2.Nome);
            Console.WriteLine("ENERGIA DO JOGADOR {0}: {1}", Player2.Nome, Player2.Energia);
        }
    }
}