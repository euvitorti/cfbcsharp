//ESTRUTURA WHILE
using System;
class Aula19{
    static void Main(){
        int[] num = new int [10];
        int i = 0;
        while(i < num.Length){
            Console.WriteLine(num[i]);
            num[i] = i++; 
        }
    }
}