//ESTRUTURA FOR
using System;
class Aula18{
    static void Main(){
        int[] numero = new int[11];
        //i < numero.Length (ATÉ O LIMITE DO TAMANHO DO ARRAY)
        for(int i = 1; i < numero.Length; i ++){
            numero[i] = i;
            Console.WriteLine(numero[i]);
        }
    }
}