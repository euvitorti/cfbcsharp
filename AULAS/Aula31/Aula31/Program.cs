// OPERADOR THIS/ REFERÊNCIA PARA O OBJETO QUE FAZ A CHAMADA DO MÉTODO

namespace Aula31{
using System;

    struct Operacao(){
        public int PrimeiroValor;
        public int SegundoValor;

        public Operacao(int PrimeiroValor, int SegundoValor){
            this.PrimeiroValor = PrimeiroValor;
            this.SegundoValor = SegundoValor;
        }
        public int Soma(){
            return PrimeiroValor + SegundoValor;
        }
    }
        class Program
        {
            static void Main(){
                
                Operacao calculos = new Operacao(10, 2);

                Console.WriteLine(calculos.Soma());
            }
        }   
}