using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice;
            int cantidad;

            ArrayList datos = new ArrayList();
            
            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("estos son los datos");
            imprime(datos);

            //añadimos mas datos
            datos.Add(4);
            datos.Add(5);
            // obtenemos el indice
            indice = datos.Add(10);

            Console.WriteLine("despues de hacer crecer el array");
            imprime(datos);
            Console.WriteLine("el ultimo elemento tiene el indice {0}", indice);
            Console.WriteLine("\n___________");

            //imprimir un elemento en particular
            Console.WriteLine("el valor en el indice 2 es: {0}", datos[2]);
            Console.WriteLine("\n___________");

            //modificar dato
            datos[3] = 20;
            Console.WriteLine("dato ya modificado");
            imprime(datos);

            //obtener elementos
            cantidad = datos.Count;
            Console.WriteLine("La cantidad de elementos es: {0}", cantidad);
            Console.WriteLine("\n___________");

            //insertar elemento
            datos.Insert(2, 50);
            Console.WriteLine("Despues de insertar el dato nuevo");
            imprime(datos);

            //obtener elementos
            cantidad = datos.Count;
            Console.WriteLine("La nueva cantidad de elementos es: {0}", cantidad);
            Console.WriteLine("\n___________");

            //eliminar un elemento
            datos.RemoveAt(6);
            Console.WriteLine("despues de la eliminacion");
            imprime(datos);

            //obtener elementos
            cantidad = datos.Count;
            Console.WriteLine("La nueva cantidad de elementos es: {0}", cantidad);
            Console.WriteLine("\n___________");

            //encontrar indice donde se encuentra el 5

            indice = datos.IndexOf(5);
            Console.WriteLine("el primer 5 se encuentra en: {0}", indice);
            Console.WriteLine("\n___________");

            Console.ReadKey();
        }
        static void imprime(ArrayList arreglo)
        {
            foreach(int n in arreglo)
            {
                Console.WriteLine(" {0}", n);
                Console.WriteLine("\n--------");

            }
        }
    }
}
