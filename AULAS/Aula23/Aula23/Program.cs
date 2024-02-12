//MÉTODOS
// SÃO CONJUNTOS DE INTRUÇÕES
//O MÉTODO DESSE AQUI ESPECIFICO É O MÉTODO [STATIC]

namespace System;
class Aula23{
    static void Main(){
        int valor1, valor2, valor3, valor4, retorno;

        //NÃO TEM PASSAGEM DE PARÂMETROS
        //CHAMANDO O MÉTODO PARA O MÉTODO PRINCIPAL
        Cfb();
        Console.WriteLine("");
        //SE LIGUE EM, ESSA TEM PASSAGEM
        Soma(10,5);
        Console.WriteLine("");

        //ESSA É COM LEITURA DO TECLADO
        Console.WriteLine("ESSA É COM LEITURA DO TECLADO");
        Console.WriteLine("DIGITE UM NÚMERO: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("DIGITE OUTRO: ");
        //OUTRA FORMA DE CONVERTER
        valor2 = Convert.ToInt32(Console.ReadLine());
        SomaComLeituraTeclado(valor1, valor2);
    
        //ESSA É COM O RETORNO
        Console.WriteLine("ESSA É COM RETORNO");
        Console.WriteLine("DIGITE UM NÚMERO: ");
        valor3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("DIGITE OUTRO: ");
        valor4 = Convert.ToInt32(Console.ReadLine());
        retorno = SomaComRetorno(valor3, valor4);
        Console.WriteLine("RESULTADO: ",retorno);

    }

    //CRIANDO UM MÉTODO

    static void Cfb(){
        Console.WriteLine("SOMA");
    }

    //ESTE TEM A  PASSAGEM DE VALOR
    static void Soma(int a, int b){
        int resultado = a + b;
        Console.WriteLine(resultado);
    }

    static void SomaComLeituraTeclado(int a, int b){
        int resultado = a + b;
        Console.WriteLine("RESULTADO DA SOMA: ", resultado);
    }

    //ESSA É COM O RETORNO
    static int SomaComRetorno(int a, int b){
        int resultado = a + b;
        return resultado;
    }
}