using System;

namespace arreglos1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            int i;
            float suma = 0.0f;
            float promedio;

            float minimo = 10.0f;
            float maximo = 0.0f;

            Console.WriteLine("Ingrese cantidad de alumnos");
            cantidad = Convert.ToInt32(Console.ReadLine());

            float[] calif = new float[cantidad];

            for (i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese la calificacion");
                calif[i] = Convert.ToSingle(Console.ReadLine());
            }

            for (i = 0; i < cantidad; i++)
            {
                suma += calif[i];
            }
            promedio = suma / cantidad;

            for (i = 0; i < cantidad; i++)
            {
                if (calif[i] < minimo)
                {
                    minimo = calif[i];
                }
            }

            for (i = 0; i < cantidad; i++)
            {
                if (calif[i] > maximo)
                {
                    maximo = calif[i];
                }
            }
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificacion maxima es: {0}", maximo);
            Console.WriteLine("La calificacion minima es: {0}", minimo);

            Console.ReadKey();
        }
        
    }
}
