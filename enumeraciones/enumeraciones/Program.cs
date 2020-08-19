using System;

namespace enumeraciones
{
    class Program
    {
        //declaracion de enumeraciones
        enum semana {Lunes,Martes,Miercoles,Jueves,Viernes,Sabado,Domingo}
        enum colores { Rojo =1, Verde, Azul, Amarillo}
        static void Main(string[] args)
        {
            int numerico = 0;

            //declaramos variable de tipo semana
            semana miDia;

            //asignamos un valor a miDia
            miDia = semana.Lunes;

            //pasamos de enumeracion a entero
            numerico = (int)miDia;

            //mostrar informacion
            Console.WriteLine("El dia es: {0} con valor {1}",miDia,numerico);

            //crear una variable de tipo color
            colores miColor = colores.Rojo;

            //pasamos de enumeracion a entero
            numerico = (int)miColor;

            //mostrar informacion para colores
            Console.WriteLine("El color es: {0} con valor {1}", miColor, numerico);
            Console.ReadKey();
        }
    }
}
