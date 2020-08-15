using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 9;
            string nombre = "Nicolas";
            string linea;
            float estatura = 1.78f;
            int edad;
            try
            {


                do
                {

                    Console.WriteLine("Ingrese nombre: ");
                    linea = Console.ReadLine();
                    Console.WriteLine("Ingrese edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                    if (nombre == linea)
                    {
                        //Console.WriteLine("el numero es: " + numero + " Y el nombre es: " + nombre + " la estatura es: "+estatura);
                        Console.WriteLine("El numero es: {0}, Mi nombre es: {1}, mi altura es: {2}", numero, nombre, estatura);
                        Console.WriteLine("La edad es: {0}", edad);
                        foreach (char letra in nombre)
                        {
                            Console.Write(" {0} ", letra);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nombre incorrecto");
                    }
                } while (true);
            }
            catch(Exception error)

            {
                Console.WriteLine(error.Message);
            }
           // Console.WriteLine("hola soy nicolas");



            Console.ReadKey();

        }
    }
}
