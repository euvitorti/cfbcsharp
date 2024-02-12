// SOBRECARGAS DE CONSTRUTORES - ISSO PERMITE QUE POSSA TER MAIS DE UM

namespace Aula29{
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

        public Jogador(){
            Energia = 100;
            Vivo = true;
            Nome = "VÍTOR";
        }

        public Jogador(string Name, int XP){
            Energia = XP;
            Vivo = true;
            Nome = Name;
        }

        public Jogador(string Name, int XP, bool Vida){
            Energia = XP;
            Vivo = Vida;
            Nome = Name;
        }

        public void Informacao(){
            Console.WriteLine("NOME: {0}",Nome);
            Console.WriteLine("ENERGIA: {0}",Energia);
            Console.WriteLine("VIDA: {0}\n",Vivo);
        }
    }

    //QUANDO NÃO USA NENHUM MODIFICADOR A CLASSE É PÚBLICA
    public class Program
    {
        static void Main(){
            
            string Resposta;
            int XP;
            bool Vida;
            string NomeJogador2;
            string NomeJogador3;
            string NomeJogador4;
            string NomeJogador5;
            
            Console.WriteLine("DIGITE O NOME DO JOGADOR 2: ");
            NomeJogador2 = Console.ReadLine();

            Console.WriteLine("DIGITE O NOME DO JOGADOR 3: ");
            NomeJogador3 = Console.ReadLine();      

            Console.WriteLine("VIDA DO JOGADOR 3: ");
            XP = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE O NOME DO JOGADOR 4: ");
            NomeJogador4 = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("VIDA DO JOGADOR 4: ");
            XP = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("O JOGADOR 4 ESTÁ VIVO OU MORTO? [S/N]");
            Resposta = Console.ReadLine();

            if (Resposta == "S"){
                Vida = true;
            } else{
                Vida = false;
            }

            Console.WriteLine("DIGITE O NOME DO JOGADOR 5: ");
            NomeJogador5 = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("VIDA DO JOGADOR 5: ");
            XP = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("O JOGADOR 5 ESTÁ VIVO OU MORTO? [S/N]");
            Resposta = Console.ReadLine();

            if (Resposta == "S"){
                Vida = true;
            } else{
                Vida = false;
            }

            Console.WriteLine("");

            //CRIANDO UM OBJETO, USA O OPERADOR NEW, VAI NA MÉMORIA RAM CRIAR UM ESPAÇO PARA ESSE OBJETO
            Jogador Player = new Jogador();

            Jogador Player2 = new Jogador(NomeJogador2);
            
            Jogador Player3 = new Jogador(NomeJogador3, XP);
            
            Jogador Player4 = new Jogador(NomeJogador4, XP, Vida);
            
            Jogador Player5 = new Jogador(NomeJogador5, XP, Vida);
            
            // Console.WriteLine("JOGADOR 1: {0}. ENERGIA: {1}. VIDA: {2}", Player.Nome, Player.Energia, Player.Vivo);
            // Console.WriteLine("");

            // Console.WriteLine("JOGADOR 2: {0}, ENERGIA: {1}. VIDA: {2}", Player2.Nome, Player2.Energia, Player2.Vivo);
            // Console.WriteLine("");

            // Console.WriteLine("JOGADOR 3: {0}, ENERGIA: {1}. VIDA: {2}", Player3.Nome, Player3.Energia, Player3.Vivo);
            // Console.WriteLine("");

            // Console.WriteLine("JOGADOR 4: {0}, ENERGIA: {1}. VIDA: {2}", Player4.Nome, Player4.Energia, Player4.Vivo);
            // Console.WriteLine("");
        
            
            // Console.WriteLine("JOGADOR 5: {0}, ENERGIA: {1}. VIDA: {2}", Player5.Nome, Player5.Energia, Player5.Vivo);
            // Console.WriteLine("");

            Player.Informacao();
            Player2.Informacao();
            Player3.Informacao();
            Player4.Informacao();
            Player5.Informacao();
            Console.WriteLine("FIM");
        }
    }
}