//CONDIÇÃO
//FIRST PROGRAM

using System;
class Aula12{
    static void Main(){
        int a, b, media;
        string resultado = "REPROVADO";

        Console.WriteLine("Primeira nota: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Segunda nota: ");
        b = int.Parse(Console.ReadLine());

        media = (a + b) / 2;

        if(media >= 7){
            resultado = "APROVADO";
        }

        Console.WriteLine("Média de {0} pontos. {1}!",media, resultado);
    }
}