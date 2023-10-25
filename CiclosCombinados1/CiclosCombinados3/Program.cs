using System;
using System.Security.Cryptography.X509Certificates;

namespace CiclosCombinados3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            int n = 1, con, conGral = 0;
            Console.WriteLine("Ingrese un numero: ");
            while (n >= 0)
            {
                conGral++;
                con = 0;
                n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    con++;


                    Console.WriteLine("Ingrese un numero: ");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La lista Nº: " + conGral + " Contiene: " + con + " positivos..");
                
            }
           

            Console.WriteLine("FIN DEL PROGRAMA!!");
            
                
        }
    }
}