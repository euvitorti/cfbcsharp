// PRIVATE X PUBLIC
// PRIVATE - SÓ PODE SER ACESSADO POR DENTRO DA CLASSE

namespace Aula32{

    class Jogador{
        private int Energia;
        private string Nome;
        public Jogador(string nome){
            this.Nome = nome;
            Energia = 100;
        }

        // PARA USAR OS VALORES DEVE CRIAR MÉTODOS
        public int GetEnergia(){
            return Energia;
        }

        public string GetNome(){
            return Nome;
        }

        public void SetEnergia(int energia){
            
            if(energia < 0){
            
                if(Energia + energia < 0){
                    Energia = 0;
                } else{
                    // - COM - DA MAIS, ENTÃO TEM QUE JOGAR UM MAIS PARA FAZER A OPERÇÃO DE SUBTRAÇÃO
                    Energia += energia;
                }
            
            } else if(energia > 0){

                if(Energia + energia > 100){
                    Energia = 100; 
                } else{
                    Energia += energia;
                }
            }
        }
    }

    class Program
    {
        static void Main(){
            
            Jogador Player = new Jogador("Vítor");

            Player.SetEnergia(-150);

            Console.WriteLine($"NOME: {Player.GetNome()}.");
            Console.WriteLine($"ENERGIA: {Player.GetEnergia()}.");
        }
    }
}