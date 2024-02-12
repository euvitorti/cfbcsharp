using System;

namespace AULA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My first program in c# language!");
            if(args.GetLength(0)>0){
            Console.Write(args.GetValue(0));
            }
        }
    }
}