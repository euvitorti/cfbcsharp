//CONDIÇÃO
//FIRST PROGRAM

using System;
class Aula12{
    static void Main(){
        float a, b, media;
        string resultado;

        Console.WriteLine("Primeira nota: ");
        a = float.Parse(Console.ReadLine());

        Console.WriteLine("Segunda nota: ");
        b = float.Parse(Console.ReadLine());

        media = (a + b) / 2;

        if (media < 5){
            resultado = "Reprovado";
        } else if (media <= 6.9){
            resultado = "Recuperação";
        } else {
            resultado = "Aprovado";
        }

        Console.WriteLine("Média de {0} pontos. {1}!",media, resultado);
    }
}