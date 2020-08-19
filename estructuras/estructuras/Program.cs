using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace estructuras
{
    class Program
    {
        public struct Direccion
        {
            public String calle;
            public int numero;

            //metodo constructor de estructura direccion
            public Direccion(String pCalle, int pNumero)
            {
                calle = pCalle;
                numero = pNumero;

            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(" Direccion: {0} #{1}", calle, numero);
                return (sb.ToString());
            }
        }
        //CRAMOS NUESTRA ESTRUCTURA FUERA DEL METODO PRINCIPAL MAIN PARA PODER USARLA
        public struct Agenda
        {
            public String nombre;
            public String telefono;
            public int edad;
            public Direccion domicilio;

            //1 SOBRECARGA
            public Agenda(String pNombre, String pTelefono, int pEdad, String pCalle, int pNumero)//metodo constructor
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
                domicilio = new Direccion(pCalle, pNumero);
                
            }
            //2 SOBRECARGA
            public Agenda(String pNombre, int pEdad)
            {
                nombre = pNombre;
                edad = pEdad;
                telefono = "Sin telefono";
                domicilio = new Direccion("Sin direccion",0);
            }
            //3 SOBRECARGA
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
                domicilio = new Direccion("Sin direccion", 0);
            }
            /*
            //4 SOBRECARGA
            public Agenda(int codigo)
            {
                Console.WriteLine("Ingrese nombre");
                nombre = Console.ReadLine();

                //pedir edad
                Console.WriteLine("Ingrese su edad");
                edad = Convert.ToInt32(Console.ReadLine());

                //pedir telefono
                Console.WriteLine("Ingrese telefono");
                telefono = Console.ReadLine();

                if (telefono.Length < 8)
                {
                    telefono = "Sin telefono";
                }
                domicilio = new Direccion(pCalle, pNumero);
            }*/

            /*llamamos el metodo ToString con acceso publico y le pasamos la clase override para que
             * limpie el metodo ToString y nos permita programarlo a nosotros mismos
             */
            public override string ToString()
            {
                //usamos la clase StringBuilder con su metodo AppendFormat para darle un formato a la cadena
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Telefono: {1}, Edad: {2}", nombre, telefono, edad);

                //adicionamos la cadena que viene del domicilio
                sb.Append(domicilio.ToString());
                return (sb.ToString());//retornamos el sb con el metodo ToString ya programado
            }
        }
        static void Main(string[] args)
        {

            //invocamos el metodo constructor
            Agenda amigo = new Agenda("Jorge","564488219",35,"Av Principal",112);
            Agenda amigo1 = new Agenda("Pedro", "23588524", 25,"Av 2",500);
            Agenda amigo2 = new Agenda("Jose", 28);
            Agenda amigo3 = new Agenda("Marta");
            //Agenda amigo4 = new Agenda(1);

            Console.WriteLine(amigo.ToString());
            Console.WriteLine(amigo1.ToString());
            Console.WriteLine(amigo2.ToString());
            Console.WriteLine(amigo3.ToString());
            //Console.WriteLine(amigo4.ToString());

            Console.ReadKey();
        }
        
    }

}
