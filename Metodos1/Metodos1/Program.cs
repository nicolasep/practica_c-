using System;

namespace Metodos1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            float resultado = 0;

            float n1;
            float n2;


            Console.WriteLine("1. suma");
            Console.WriteLine("2. resta");
            Console.WriteLine("3. multiplicacion");
            Console.WriteLine("4. division");
            Console.WriteLine("elija una opcion");
            opcion = Convert.ToInt32(Console.ReadLine());

            if(opcion == 1)
            {
                suma();
            }
            if (opcion == 2)
            {
                resultado = resta();
                Console.WriteLine("el resultado es: {0}", resultado);
            }
            if (opcion == 3)
            {
                Console.WriteLine("Ingrese primer numero: ");
                n1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingrese segundo numero: ");
                n2 = Convert.ToSingle(Console.ReadLine());

                multiplicacion(n1, n2);
            }
            if (opcion == 4)
            {
                Console.WriteLine("Ingrese primer numero: ");
                n1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingrese segundo numero: ");
                n2 = Convert.ToSingle(Console.ReadLine());

                resultado = division(n1, n2);

                Console.WriteLine("el resultado es: {0}", resultado);
            }

            Console.ReadKey();

        }
        static void suma()
        {
            float a;
            float b;
            float r = 0;
            

            Console.WriteLine("Ingrese primer numero: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero: ");
            b = Convert.ToSingle(Console.ReadLine());

            r = a + b;

            Console.WriteLine("el resultado es: {0}", r);
        }
        static float resta()
        {
            float a;
            float b;
            float r = 0;

            Console.WriteLine("Ingrese primer numero: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero: ");
            b = Convert.ToSingle(Console.ReadLine());

            r = a - b;

            return r;

        }
        static void multiplicacion(float a, float b)
        {
            float r;
            r = a * b;

            Console.WriteLine("el resultado es: {0}", r);
        }
        static float division(float a, float b)
        {
            float resultado = 0;

            if(b == 0)
            {
                Console.WriteLine("No es posible dividir por cero");
            }
            else
            {
                resultado = a / b;
            }
            
            return resultado;
        }
    }
}
