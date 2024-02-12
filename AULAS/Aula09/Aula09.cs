//Operadores para a esquerda (<<) irá dobrar e para direita (>>) dimiuir pela metade [OPERACÃO DE BITWISE]
using System;
class Aula09{
    static void Main(){
        int num = 2;

        num = num<<2;//var<<2; dobra duas vezes

        Console.WriteLine(num);
    }
}