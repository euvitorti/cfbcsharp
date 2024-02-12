//LER VALORES DO TECLADO
using System;
class Aula08{
    static void Main(){
        int v1, v2, soma;
        string nome;

        Console.Write("Digite um número: ");
        //Duas formas de converter os parânmetros
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite outro: ");
        //Duas formas de converter os parânmetros
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine("A soma entre {0} e {1} é {2}.",v1,v2,soma);
    }
}