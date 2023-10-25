using System;

namespace ciclosCombinados2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int n, impar, con, grupoImparMaximo = 0, minimo, contadorOrdenados = 0;
            double porcentajeImpar, porcentajeMaximo = -1;
            bool banderaOrdenados;
            Console.WriteLine("Ingrese un numero: ");
        
            for (int x = 0; x < 5; x++)
            {
                
                con = 0;
                impar = 0;
                banderaOrdenados = true;
                n = int.Parse(Console.ReadLine());
                minimo = n;
                while (n != 0){

                    con++;
                    if(n % 2 != 0)
                    {
                    impar++;
                    }

                    if (n <= minimo)
                    {
                        minimo = n;
                    }else
                        banderaOrdenados = false;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
                }
                porcentajeImpar = impar * 100 / con;
                if (porcentajeImpar > porcentajeMaximo)
                {
                    porcentajeMaximo = porcentajeImpar;
                    grupoImparMaximo = x + 1;
                }
                if (banderaOrdenados == true)
                    contadorOrdenados++;
            }
            Console.WriteLine("El grupo con mayor porcentaje es: " + grupoImparMaximo);
            Console.WriteLine("La cantidad de grupos ordenados es: " + contadorOrdenados);
            
        }
    }
}
