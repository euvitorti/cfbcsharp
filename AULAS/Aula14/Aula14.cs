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

        if (media >= 5){
            resultado = "Aprovado";
            if (media >= 7){
                resultado = "Aprovado, Parabéns";
            }
        } else {
            resultado = "Recuperação";
            if (media <= 3){
                resultado = "Reprovado, estude mais.";
            }
        }

        Console.WriteLine("Média de {0} pontos. {1}!",media, resultado);
    }
}