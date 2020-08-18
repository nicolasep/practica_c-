using System;
using System.Text;

namespace estructuras
{
    class Program
    {
        public struct Agenda
        {
            public String nombre;
            public String telefono;
            public int edad;

            public Agenda(String pNombre, String pTelefono, int pEdad)//metodo constructor
            {
                nombre = pNombre;
                
                edad = pEdad;
                if(pTelefono.Length>=8)
                {
                    telefono = pTelefono;
                }
                else
                {
                    telefono = "Telefono no valido, ingrese nuevamente";
                }
            }
            public Agenda(String pNombre, int pEdad)
            {
                nombre = pNombre;
                edad = pEdad;
                telefono = "Sin telefono";
            }
            public Agenda(String pNombre)
            {
                nombre = pNombre;

                //pedir edad
                Console.WriteLine("Ingrese su edad");
                edad = Convert.ToInt32(Console.ReadLine());

                //pedir telefono
                Console.WriteLine("Ingrese telefono");
                telefono = Console.ReadLine();

                if(telefono.Length < 8)
                {
                    telefono = "Sin telefono";
                }
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Telefono: {1}, Edad: {2}", nombre, telefono, edad);
                return (sb.ToString());
            }
        }
        static void Main(string[] args)
        {

            //invocamos el metodo constructor
            Agenda amigo = new Agenda("Jorge","564488219",35);
            Agenda amigo1 = new Agenda("Pedro", "23588524", 25);
            Agenda amigo2 = new Agenda("Jose", 28);

            Agenda amigo3 = new Agenda("Marta");

            Console.WriteLine(amigo.ToString());
            Console.WriteLine(amigo1.ToString());
            Console.WriteLine(amigo2.ToString());
            Console.WriteLine(amigo3.ToString());

            Console.ReadKey();
        }
        
    }

}
