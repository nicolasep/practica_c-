using System;
using System.Collections;

namespace coleccionQueue_o_cola
{
    class Program
    {
        static void Main(string[] args)
        {
            //cuando se agrega se hace en el ultimo lugar y cuando se borra, se borra desde el primero


            int opcion = 0;
            int numero = 0;
            bool encontrado = false;
            
            Queue miFila = new Queue();

            do
            {
                //menu de opciones
                Console.WriteLine("1. enqueue");
                Console.WriteLine("2. dequeue");
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
                    miFila.Enqueue(numero);
                }
                if (opcion == 2)
                {
                    //obtener elemento
                    numero = (int)miFila.Dequeue();

                    //mostramos el elemento tomado
                    Console.WriteLine("el valor obtenido es: {0}", numero);
                }
                if (opcion == 3)
                {
                    //limpiamos todos los elementos
                    miFila.Clear();

                }
                if (opcion == 4)
                {
                    //pedimos el valor a mostrar
                    Console.WriteLine("Ingrese el valor a encontrar");
                    numero = Convert.ToInt32(Console.ReadLine());

                    //miramos si el elemento se encuentra
                    encontrado = miFila.Contains(numero);

                    Console.WriteLine("encontrado: {0}", encontrado);

                }
                //mostrar la informacion del queue

                Console.WriteLine("el queue tiene: {0} elementos", miFila.Count);
                foreach(int n in miFila)
                {
                    Console.WriteLine(" {0}", n);
                    Console.WriteLine("");
                    Console.WriteLine("_______");
                }

            } while (opcion != 5);

            Console.ReadKey();

        }
    }
}
