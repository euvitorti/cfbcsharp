// ARRAY DINÂMICO, USADA PARA SUBSTITUIR UM ARRAY TRADICIONAL

namespace ColecaoLista
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            List<string> modeloCarros = new List<string>();
            // List<string> segundoModeloCarros = new List<string>();

            string[] segundoModeloCarros = new string[2];

            modeloCarros.Add("HYUNDAI");
            modeloCarros.Add("KIA");
            modeloCarros.Add("RENAULT");
            modeloCarros.Add("FIAT");

            modeloCarros.Insert(1, "MONZA");
            modeloCarros.Insert(1, "HRV");
            modeloCarros.Insert(6, "HRV");

            // segundoModeloCarros.AddRange(modeloCarros);

            // modeloCarros.CopyTo(segundoModeloCarros, 2);

            foreach (string nomeCarros in modeloCarros)
            {
                Console.WriteLine($"MODELO DO CARRO: {nomeCarros}");
            }

            int pos = modeloCarros.LastIndexOf("HRV");
            Console.WriteLine($"ÚLTIMA POSIÇÃO DO HRV: {pos}");
        }
    }
}