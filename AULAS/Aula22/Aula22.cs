//METODOS PARA MANIPULAR ARRAYS

using System;
class Aula22{
    static void Main(){
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};
        
        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++){
            vetor1[i] = random.Next(50);
        }
        Console.WriteLine("Elementos do vetor1");
        foreach (int n in vetor1){
            Console.WriteLine(n);
        }

        //public static int BINARYSEARCH(array, valor);
        Console.WriteLine("BINARYSEARCH");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine("VALOR {0} ESTÁ NA POSIÇÃO {1}", procurado, pos);
        Console.WriteLine("---------------------------------------------");

        //public static void Copy(Ar_Origem, Ar_Destino, qtde_elementos);
        Console.WriteLine("COPY");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------------");

        //public void CopyTo(Ar_Destino, A_Partir_Desta_Pos)
        Console.WriteLine("COPYTO");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3){
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------------");

        //PUBLIC lONG GETLONGLENGTH(DIMENSÃO)
        Console.WriteLine("GETLONGLENGTH");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("-----------------------------------------------");

        //PUBLIC INT GETLOWERBOUND(DIMENSÃO)
        Console.WriteLine("GETLOWERBOUND");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("MENOR INDICE DO VETOR1 {0}",MenorIndiceVetor);
        Console.WriteLine("-------------------------------------------");

        //PUBLIC INT GETUPPERBOUND(DIMENSÃO)
        Console.WriteLine("GETUPPERBOUND");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("VALOR DA POSIÇÃO 3 DO VETOR1: {0}", MaiorIndiceVetor);
        Console.WriteLine("---------------------------------------------------");

        //PUBLIC OBJECT GETVALUE(LONG INDICE)
        Console.Write("GETVALUE");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));       
        Console.WriteLine("VALOR DA POSIÇÃO 3 DO VETOR1: {0}",valor0);
        Console.WriteLine("----------------------------------------");

        //PUBLIC STATIC INT INDEXOF(ARRAY, VALOR);
        Console.WriteLine("INDEXOF");
        int indice1 = Array.IndexOf(vetor1,3);
        Console.WriteLine("INDICE DO PRIMEIRO VALOR 3:{0}",indice1);
        Console.WriteLine("--------------------------------------");

        //public static int LastIndexOf(ARRAY,VALOR)
        Console.WriteLine("LASTINDEXOF");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("INDICE DO ÚLTIMO VALOR 33:{0}",indice2);
        Console.WriteLine("-------------------------------------");

        //public static void reverse(array); inverter os valores
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        //public void setvalue(object valor, long pos);
        vetor2.SetValue(99,0);
        for (int i = 0; i < vetor2.Length; i++){
            vetor2.SetValue(0,i);
        } 
        Console.WriteLine("VETOR 2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }

        //public static void sort(array);
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("VETOR 1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor 2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor 3");
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
    }
}