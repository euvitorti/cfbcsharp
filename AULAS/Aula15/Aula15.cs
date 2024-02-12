//TODO(NÃO ESQUECER PARA QUANDO EU APRENDER FUNÇÃO)

using System;
class Aula15{
    static void Main(){
        int escolha, tempo = 0;
        char menu;

        inicio:

        Console.WriteLine("BH Á BA");
        Console.WriteLine("Escolha o transporte. ");
        Console.WriteLine("[1] AVIÃO [2] CARRO [3] ÔNIBUS: ");
        escolha = int.Parse(Console.Read());

        switch(escolha){
            case 1:
                tempo = 50;
                break;
            case 2:
                tempo = 4320;
                break;
            case 3:
                tempo = 8640;
                break;
            default:
                tempo = =1;
                break;
        }
        Console.WriteLine("PARA O TRANSPORTE ESCOLHIDO O TEMPO É DE {0} MINUTOS.", tempo);
        Console.WriteLine("CALCULAR NOVAMENTE? [S/N] ");
        menu = char.Parse(Console.Read());
        if (menu == 'S'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("PROGRAMA ENCERRADO.");
        }
    }
}