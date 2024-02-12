//ENUM - ENUMERADORES
using System;
class Aula10{
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main(){
        //RETORNANDO O VALOR NO ÍNDICE
        //DiasSemana ds = (DiasSemana)0;

        //FAZENDO A TRANSIÇÃO DE SEXTA PARA INTEIRO
        int ds = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);
    }
}