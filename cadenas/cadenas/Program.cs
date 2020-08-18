using System;

namespace cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de la cadena


            String miCadena = "hola a todos";
            String dato = "y bienvenidos";
            int valor = 10000;

            //metodo ToString

            String cadena = valor.ToString();

            //fechas y horas
            String formato;
            formato = String.Format("La fecha es: {0:dddd d MMMM yyyy h:m s tt}", DateTime.Now);
            Console.WriteLine(formato);

            //formato numerico
            Console.WriteLine(String.Format("{0:$#,####0.00}", valor));

            //concatenacion
            String nombreCompleto = String.Concat(miCadena, dato);
            String mensaje = String.Format("Imprimir mensaje: {0}", nombreCompleto);
            Console.WriteLine(mensaje);

            string nombre = "Pedro";
            string apellido = "Gomez";

            String NombreCompleto = String.Concat(nombre, String.Concat(" ", apellido));

            Console.WriteLine(NombreCompleto);


            //comparacion de cadenas

            int comparacion;
            comparacion = String.Compare(nombre, apellido);

            if (comparacion == 0)
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("Las cadenas no son iguales");
            }

            //encontrar cadena
            String Nombrecompleto1 = "Jose alameda villa";
            String NombreBuscar = "alameda";

            if (Nombrecompleto1.Contains(NombreBuscar) == true)
            {
                Console.WriteLine("El nombre existe");
            }
            else
            {
                Console.WriteLine("El nombre no existe");
            }

            //extraer subcadena
            String resultado = "";
            resultado = miCadena.Substring(7, 5);
            Console.WriteLine(resultado);

            //determinar si la cadena finaliza en subcadena
            String cadena1 = "Juan Alberto Tabarez";
            String cadena2 = "Tabarez";

            if (cadena1.EndsWith(cadena2) == true)
            {
                Console.WriteLine("La cadena finaliza en tabarez");

            }
            else
            {
                Console.WriteLine("La cadena no finaliza en tabarez");
            }

            //copiar una parte de la cadena

            char[] destino = new char[20];
            String saludo = "Hola a todos los estudiantes";
            saludo.CopyTo(17, destino, 0, 11);
            Console.WriteLine(destino);

            //insertar una cadena en otra
            String cadena3 = "Hola como ";
            String cadena4 = "estan";
            String resultado2 = "";
            resultado2 = cadena3.Insert(10, cadena4);
            Console.WriteLine(resultado2);

            //encontrar subcadena
            int indice = 0;
            String cadena5 = "Bienvenidos a este curso";
            Console.WriteLine(cadena5);
            indice = cadena5.LastIndexOf("curso");
            Console.WriteLine(indice);

            //justificar cadenas (espacios)

            String cadena6 = "hola";
            String resultado3 = "";
            resultado3 = cadena6.PadLeft(10);//genera 10 espacios a la izquierda
            //resultado3 = cadena6.PadRight(10); genra 10 espacios a la derecha
            Console.WriteLine(resultado3);

            //eliminar caracteres
            String resultado4 = "";
            resultado4 = cadena5.Remove(19, 5);
            Console.WriteLine(resultado4);

            //reemplazar una palabra por otra dentro de una cadena

            String cadena7 = "ADIOS";
            String resultado5 = "";

            resultado5 = cadena5.Replace("Bienvenidos", cadena7);
            Console.WriteLine(resultado5);

            //convertir cadenas a mayusculas o minusculas
            String resultado6 = "";
            resultado6 = cadena7.ToLower();
            Console.WriteLine(resultado6);

            String resultado7 = "";
            resultado7 = resultado6.ToUpper();
            Console.WriteLine(resultado7);

            //eliminar espacios en una cadena
            String cadena8 = "   Hola a todos    ";
            String resultado8 = "";
            resultado8 = cadena8.TrimEnd();//o tambien .Trim
            Console.WriteLine(resultado8);

            Console.ReadKey();

        }
    }
}
