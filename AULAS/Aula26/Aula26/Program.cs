//PARAMS, QUANDO NÃO SABE QUANTOS VALORES SERÃO PASSADOS

namespace Aula26{
    class Program
    {

        // BALTAAA

        // static void Main(string[] args){
        //     Product mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);
        //     var ManutencaoEletrica = new  Product(2, "Manutenção elétric residencial", 500, EProductType.Service
        //     );

        //     Console.WriteLine(mouse.Id);
        //     Console.WriteLine(mouse.Name);
        //     Console.WriteLine(mouse.Price);
        //     Console.WriteLine(mouse.Type);
        //     Console.WriteLine((int)mouse.Type);
        
        //     Console.WriteLine(ManutencaoEletrica.Id);
        //     Console.WriteLine(ManutencaoEletrica.Name);
        //     Console.WriteLine(ManutencaoEletrica.Price);
        //     Console.WriteLine(ManutencaoEletrica.Type);
        //     Console.WriteLine((int)ManutencaoEletrica.Type);
        // }
        // struct Product{

        //     public Product(int id, string name, double price, EProductType type){
        //         Id = id;
        //         Name = name;
        //         Price = price;
        //         Type = type;
        //     }
        //     public int Id;
        //     public string Name;
        //     public double Price;
        //     public EProductType Type;

        //     public double PriceInDolar(double dolar){
        //             return Price * dolar;
        //     }
        // }

        // enum EProductType{
        //     Product = 1,
        //     Service = 2
        // }

        static void Main(){
            Soma(10, 2, 53);
        }

        static void Soma(params int [] Numeros){
            int Resultado = 0;

            if (Numeros.Length == 0){
                Console.WriteLine("NÃO EXISTEM VALORES A SEREM SOMADOS.");
            }else if (Numeros.Length < 2){
                Console.WriteLine("VALORES INSUFICIENTES PARA A SOMA: {0}",Numeros[0]);
            }else{
                for(int i = 0; i < Numeros.Length; i++){
                    Resultado += Numeros[i];
                }
            }

            if (Numeros.Length >= 2){
                for (int i = 0; i < Numeros.Length; i++){
                    Console.WriteLine(Numeros[i]);
                }
            }

            Console.WriteLine("SOMA = {0}", Resultado);
        }
    }
}