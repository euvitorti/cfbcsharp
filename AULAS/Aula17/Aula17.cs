//MATRIZ

using System;
class Aula17{
    static void Main(){
        int[,] numero = new int[2,2];
        /*
        10 11
        15 16
        LINHAS E COLUNAS
        */

        numero[0,0] = 1;
        numero[0,1] = 2;
        numero[1,0] = 3;
        numero[1,1] = 4;
        
        Console.WriteLine(numero[0,1]);
    }
}