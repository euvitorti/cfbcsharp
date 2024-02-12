using System;
class Aula11{
    static void Main(){
        
        //float n1 = 10.5f; //Colocar o {F}, para a conversão
        //int n2 = (int)n1; //TYPE CAST - CONVERSÃO EXPLICÍTA

        int vint = 10;
        short vshort = (short)vint;
        Console.WriteLine(vshort);
    }   
}

//TYPECAST - CONVERSÕES
/*error CS0266: Não é possível converter implicitamente o tipo 'int' em
        'short'. Existe uma conversão explícita. Precisa de cast?
        
        USAR A CONVERSÃO TYPE CAST, CASO OCORRA ESTE ERRO.
        */