using System;

namespace Almacen
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroEscritorios;
            decimal valorApagar;

            pedirDatos(out numeroEscritorios);
            valorApagar = calcularValor(numeroEscritorios);
            mostrarResultados(valorApagar);
        }
        static void pedirDatos(out int numeroEscritorios)
        {
            Console.WriteLine("Ingrese numero de escritorios");
            numeroEscritorios = Convert.ToInt32(Console.ReadLine());
        }
        static decimal calcularValor(int numeroEscritorios)
        {
            decimal valor = numeroEscritorios * 650;
            if(numeroEscritorios < 5)
            {
                valor = valor * 0.9M;
            }
            else
            {
                if(numeroEscritorios >= 5 && numeroEscritorios <10)
                {
                    valor = valor * 0.8M;
                }
                else
                {
                    valor = valor * 0.6M;
                }
            }
            return valor;
        }
        static void mostrarResultados(decimal valorApagar)
        {
            Console.WriteLine("El valor a pagar es: ${0:N0}", valorApagar);
            Console.ReadKey();
        }
    }
}
