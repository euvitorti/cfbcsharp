// CLASSES E OBJETOS

namespace Aula27{
        public class Jogador{
            public int Energia = 100;
            public bool Vivo = true;

        }

        //QUANDO NÃO USA NENHUM MODIFICADOR A CLASSE É PÚBLICA
        public class Program
        {
            static void Main(){
                //CRIANDO UM OBJETO, USA O OPERADOR NEW, VAI NA MÉMORIA RAM CRIAR UM ESPAÇO PARA ESSE OBJETO
                Jogador Player = new Jogador();
                Jogador Player2 = new Jogador();

                Player.Energia = 50;
                Console.WriteLine("ENERGIA DO JOGADOR 1: {0}", Player.Energia);
                Console.WriteLine("ENERGIA DO JOGADOR 2: {0}", Player2.Energia);
            }
        }
    }