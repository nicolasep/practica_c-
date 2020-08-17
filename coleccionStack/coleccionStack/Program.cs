using System;
using System.Collections;

namespace coleccionStack
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            int numero = 0;
            bool encontrado = false;

            Stack miPila = new Stack();

            do
            {
                //menu de opciones
                Console.WriteLine("1. push");
                Console.WriteLine("2. pop");
                Console.WriteLine("3. clear");
                Console.WriteLine("4. contains");
                Console.WriteLine("5. salir");
                Console.WriteLine("elija una opcion");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    //pedimos el valor a introducir
                    Console.WriteLine("ingrese un valor");
                    numero = Convert.ToInt32(Console.ReadLine());

                    // adicionamos el valor a stack
                    miPila.Push(numero);
                }
                if (opcion == 2)
                {
                    //obtener elemento
                    numero = (int)miPila.Pop();

                    //mostramos el elemento tomado
                    Console.WriteLine("el valor obtenido es: {0}", numero);
                }
                if (opcion == 3)
                {
                    //limpiamos todos los elementos
                    miPila.Clear();

                }
                if (opcion == 4)
                {
                    //pedimos el valor a mostrar
                    Console.WriteLine("Ingrese el valor a encontrar");
                    numero = Convert.ToInt32(Console.ReadLine());

                    //miramos si el elemento se encuentra
                    encontrado = miPila.Contains(numero);

                    Console.WriteLine("encontrado: {0}", encontrado);

                }
                //mostrar la informacion del stack

                Console.WriteLine("el stack tiene: {0} elementos", miPila.Count);

            } while (opcion != 5);

            Console.ReadKey();
        }
    }
}
