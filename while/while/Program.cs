using System;

namespace whil
{
    class Program
{
    static void Main(string[] args)
    {
        int temperatura;


        Console.WriteLine("ingrese la termperatura actual");
        temperatura = Convert.ToInt32(Console.ReadLine());

        while (temperatura > 20)
        {
            temperatura--;
            Console.WriteLine("La temperatura -> {0}", temperatura);
        }
        Console.WriteLine("la temperatura final es: {0}",temperatura);


        Console.ReadKey();
    }
}
}
