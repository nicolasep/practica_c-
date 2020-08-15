using System;

namespace ArreglosJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            int salones = 0;
            int n = 0;
            int m = 0;
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;

            Console.WriteLine("Ingrese la cantidad de salones");
            salones = Convert.ToInt32(Console.ReadLine());

            float[][] calif = new float[salones][];

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Ingrese cantidad de alumnos para el salon {0}", n + 1);
                cantidad = Convert.ToInt32(Console.ReadLine());

                calif[n] = new float[cantidad];


            }
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n + 1);
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.WriteLine("Ingrese calificacion");
                    calif[n][m] = Convert.ToSingle(Console.ReadLine());

                }
            }
            Console.WriteLine("Informacion");
            for(n = 0; n<salones; n++)
            {
                Console.WriteLine("salon {0}", n);
                for(m=0; m< calif.GetLongLength(0); m++)
                {
                    Console.WriteLine("el alumno {0} tiene {1}", m + 1, calif[n][m]);
                }
            }
            promedio = suma / (salones * cantidad);

            for(n=0; n < salones; n++)
            {
                for(m=0; m<calif[n].GetLongLength(0);m++)
                {
                    if(calif[n][m]>maxima)
                    {
                        maxima = calif[n][m];
                    }
                }
            }
            Console.WriteLine("el promedio es: {0}", promedio);
            Console.WriteLine("la calificacion maxima es: {0}", maxima);
            Console.WriteLine("la calificacion minima es: {0}", minima);


            Console.ReadKey();
        }
    }
}
