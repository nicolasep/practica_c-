using System;

namespace clases_1
{
    class Cubo //creamos clase cubo
    {
        //declarar datos
        public int lado;
        public int area;
        public int volumen;

        //metodo para calcular el area
        public void CalcularArea()
        {
            area = (lado * lado) * 6;
        }
        //metodo para calcular el volumen
        public void CalcularVolumen()
        {
            volumen = lado * lado * lado;
        }
    }
    class Prisma
    {
        //declarar datos
        private int ancho;
        private int alto;
        private int espesor;
        private int area;
        private int volumen;

        //definimos las propiedades
        public int Ancho
        {
            get
            {
                return ancho;
            }
            set
            {
                if(value <= 0)
                {
                    ancho = 1;
                }
                else
                {
                    ancho = value;
                }
            }
        }
        public int Alto
        {
            get
            {
                return Alto;
            }
            set
            {
                if (value <= 0)
                {
                    alto = 1;
                }
                else
                {
                    Alto = value;
                }
            }
        }
        public int Espesor
        {
            get
            {
                return espesor;
            }
            set
            {
                if (value <= 0)
                {
                    espesor = 1;
                }
                else
                {
                    Espesor = value;
                }
            }
        }
        public int Area
        {
            get
            {
                return area;
            }
            
        }
        public int Volumen
        {
            get
            {
                return volumen;
            }

        }
        //definimos constructores
        public Prisma()
        {
            //pedir los datos
            Console.WriteLine("Ingrese el ancho");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el alto");
            alto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el espesor");
            espesor = Convert.ToInt32(Console.ReadLine());
        }
        public void CalcularVolumen()
        {
            volumen = ancho * alto * espesor;
        }
        public void CalcularArea()
        {
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            a1 = 2 * CalcularRectangulo(ancho, alto);
            a2 = 2 * CalcularRectangulo(ancho, espesor);
            a3 = 2 * CalcularRectangulo(alto, alto);

            area = a1 + a2 + a3;
        }
        private int CalcularRectangulo(int a, int b)
        {
            return (a * b);
        }
        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Ancho " + ancho.ToString() + " Alto " + alto.ToString() + " Espesor " + espesor.ToString();
            mensaje += " Area " + area.ToString() + " Volumen " + volumen.ToString();
            return mensaje;
        }
        public void ImprimirResultado()
        {
            Console.WriteLine("El area es {0}, volumen {1} ", area, volumen);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos a la clase cubo
            Cubo miCubo = new Cubo();

            //asignamos el valor del lado
            miCubo.lado = 7;
            Cubo tuCubo = new Cubo
            {
                lado = 8
            };
            //instanciamos el prisma

            Prisma miPrisma = new Prisma();


            //invocar metodos del cubo
            miCubo.CalcularArea();
            miCubo.CalcularVolumen();

            tuCubo.CalcularArea();
            tuCubo.CalcularVolumen();

            //invocamos los metodos del prisma

            miPrisma.CalcularArea();
            miPrisma.CalcularVolumen();

            //mostrar datos
            Console.WriteLine("Area = {0}, Volumen = {1}", miCubo.area, miCubo.volumen);
            Console.WriteLine("Area = {0}, Volumen = {1}", tuCubo.area, tuCubo.volumen);

            Console.WriteLine(miPrisma.ToString());
            miPrisma.ImprimirResultado();

            Console.ReadKey();
        }
    }
}
