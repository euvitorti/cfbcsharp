using System;
class Aula06{
    static void Main(){
        double valorcompra = 5.50;
        double valorvenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorvenda = valorcompra + (valorcompra * lucro);
        Console.WriteLine("Produto: {0,15}\t", produto);t5
        Console.WriteLine("Val.Compra: {0,15:c}\t", valorcompra);
        Console.WriteLine("Lucro: {0,15:p}\t", lucro);
        Console.WriteLine("Val.Venda: {0,15:c}\t", valorvenda);
    }
}

// \n é para quebrar linha, \t é para tabulação