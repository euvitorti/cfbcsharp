// DUPLAMENTE ENCADEADA - ONDE CADA ELEMENTO QUE TEM UM LINK PARA O ITEM ANTERIOR E O PRÓXIMO

using System.Collections.Generic;
namespace ListaLink
{
    class Program
    {
        static void Main()
        {
            LinkedList<string> transporte = new LinkedList<string>();

            Console.Clear();


            transporte.AddFirst("Carro");
            transporte.AddLast("Caminhão");

            LinkedListNode<string> node;
            node = transporte.FindLast("Carro");
            transporte.AddAfter(node, "Moto");

            node = transporte.FindLast("Caminhão");
            transporte.AddBefore(node, "Ônibus");


            foreach (string valores in transporte)
            {
                Console.WriteLine($"TRANSPORTE: {valores}");
            }
        }
    }
}