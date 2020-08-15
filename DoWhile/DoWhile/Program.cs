using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int numero1;
            int numero2;
            int respuestaInt = 0;
            float respuestaFloat = 0;

            do
            {
                Console.WriteLine("Elija una opcion:");
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - Multiplicacion");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                if(opcion == 5)
                {
                    continue;
                }

                Console.WriteLine("Ingrese el primer numero");
                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el primer numero");
                numero2 = Convert.ToInt32(Console.ReadLine());

               

                switch (opcion)
                {
                    case 1:
                        respuestaInt = numero1 + numero2;
                        break;
                    case 2:
                        respuestaInt = numero1 - numero2;
                        break;
                    case 3:
                        respuestaInt = numero1 * numero2;
                        break;
                    case 4:
                        if(numero2 != 0)
                        {
                            respuestaFloat =(float)numero1 / numero2;
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero");
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
                if(opcion == 4)
                {
                    Console.WriteLine("El resultado de la devision es: {0}", respuestaFloat);
                }
                else if(opcion >= 1 && opcion <=3)
                {
                    Console.WriteLine("El resultado de la multiplicacion es: {0}",respuestaInt);
                }
                Console.ReadKey();
                Console.Clear();


            } while (opcion != 5);
            



            Console.ReadKey();
        }
    }
}
