using System;
using System.Collections;

namespace coleccionHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            //los elementos son indexado con el indice

            int opcion = 0;
            decimal numero = 0;
            string key = "";
            bool encontrado = false;

            Hashtable miTabla = new Hashtable();

            do
            {
                //menu de opciones
                Console.WriteLine("1. add");
                Console.WriteLine("2. object");
                Console.WriteLine("3. clear");
                Console.WriteLine("4. contains o containsKeys");
                Console.WriteLine("5. containsValue");
                Console.WriteLine("6. remove");
                Console.WriteLine("7. salir");
                Console.WriteLine("elija una opcion");

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    //pedimos el valor a introducir
                    Console.WriteLine("ingrese precio del producto");
                    numero = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("ingrese nombre del producto");
                    key =Console.ReadLine();

                    // adicionamos los datos

                    miTabla.Add(key,numero);
                }
                if (opcion == 2)
                {
                    //obtener elemento
                    object llave = miTabla[key];

                    //mostramos el elemento tomado
                    Console.WriteLine("el valor obtenido es: {0}", llave);
                }
                if (opcion == 3)
                {
                    //limpiamos todos los elementos
                    miTabla.Clear();

                }
                if (opcion == 4)
                {
                    //pedimos el nombre

                    Console.WriteLine("Ingrese el nombre a encontrar");

                    key = Console.ReadLine();

                    //miramos si el elemento se encuentra
                    encontrado = miTabla.ContainsKey(key);

                    Console.WriteLine("encontrado: {0}", encontrado);

                }
                if (opcion == 5)
                {
                    //pedimos el valor a observar

                    Console.WriteLine("Ingrese el precio a encontrar");

                    numero =Convert.ToDecimal( Console.ReadLine());

                    //miramos si el elemento se encuentra
                    encontrado = miTabla.ContainsValue(numero);

                    Console.WriteLine("precio encontrado: {0}", encontrado);

                }
                if (opcion == 6)
                {
                    //removemos el hashtable
                    miTabla.Remove(key);
                    Console.WriteLine("elemento borrado: {0}", key);
                }
                //mostrar la informacion del hashtable

                
                foreach (DictionaryEntry tabla in miTabla)
                {
                    Console.WriteLine("key = {0}, value = {1}",tabla.Key,tabla.Value);
                    Console.WriteLine("");
                    Console.WriteLine("_______");
                }

            } while (opcion != 7);

            Console.ReadKey();

        }
    }
}
