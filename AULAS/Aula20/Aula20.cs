//LOOP DO WHILE, GARANTE QUE PELO MENOS, UM COMANDO VAI SER EXECUTADO

using System;
class Aula20{
    static void Main(){
        var senha = 111;
        var senhauser = 0;
        do{
            Console.Clear();
            Console.WriteLine("DIGITE A SENHA: ");
            senhauser = int.Parse(Console.ReadLine());
            if (senha != senhauser){
                Console.WriteLine("SENHA INCORRETA! DIGITE A SENHA NOVAMENTE.");
            }
        }while(senha != senhauser);
        Console.WriteLine("BEM VINDO DE VOLTA!");
    }
}