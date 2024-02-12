//PASSAGEM POR VALOR E REFERÊNCIA, ELA USA O ENDEREÇO DE MEMÓRIA DA VARIAVEL QUE FOI PASSADA COM ARGUMENTO, ALTERA O VALOR DA MEMÓRIA, ALGO QUE A PASSAGEM POR VALOR NÃO FAZ

namespace Aula24{
    class Aula24(){
        static void Main(){
            int Numero = 50;
            //ESTAR DIRETAMENTE PARA ESSE ENDEREÇO DE MEMÓRIA DA VARIAVEL NUMERO
            Dobrar(ref Numero);
            Console.WriteLine(Numero);
        }

        // REF [USAR ESSE OPERADOR PARA PASSAR O VALOR POR REFERÊNCIA]
        static void Dobrar(ref int Valor){
            Valor *= 2;
        }
    }
}