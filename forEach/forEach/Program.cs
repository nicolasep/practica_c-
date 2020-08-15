using System;

namespace forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "academia ciencia";

            foreach(char letra in nombre)
            {
                Console.Write(" {0} ", letra);
            }
            
        }
    }
}
