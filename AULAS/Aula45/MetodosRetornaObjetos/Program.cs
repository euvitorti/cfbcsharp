

namespace MetodosRetornaObjetos
{

    class Galinha
    {
        private string nomeGalinha;
        private int quantidadeOvo;
        public Galinha(string galinhaNome)
        {
            nomeGalinha = galinhaNome;
            quantidadeOvo = 0;
        }

        //MÉTODO PARA RETONAR O OBJETO
        public Ovo Botar()
        {
            quantidadeOvo++;
            return new Ovo(quantidadeOvo);
        }
    }

    class Ovo
    {
        private int ovoCriado;

        public Ovo(int criandoOvo)
        {
            ovoCriado = criandoOvo;
            Console.WriteLine($"GALINHA COLOCOU {ovoCriado} PINTO NO MUNDO");
        }
    }

    class Program
    {
        static void Main()
        {
            Galinha ticlitlle = new Galinha("BENEDITASGILDIMAR");

            ticlitlle.Botar();
        }
    }
}