using System;

namespace Metodos_y_Arrays___C2_Ej21
{
    class ArraysAleatorios
    {
        public void Rellenarvalores(int[] argarray, int min, int max)
        {
            ArraysAleatorios aleato = new ArraysAleatorios();

            for (int i = 0; i < argarray.Length; i++)
            {
                argarray[i] = aleato.aleatorio(min, max);

            }
        }
        private int aleatorio(int min, int max)
        {
            Random numeroaleatorio = new Random();
            return numeroaleatorio.Next(min, max);
        }
        static void Main(string[] args)
        {
            int[] primerarray,segundoarray;
            int max = 300;
            int min = 1;
            int longitud;
            int digito;
            Boolean digitocorrecto = false;
            ArraysAleatorios miarray = new ArraysAleatorios();
            Console.WriteLine("Introduce la longitud del array:");
            longitud = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Introduce el digito:");
                digito = Convert.ToInt32(Console.ReadLine());
                if ((digito == 0) | (digito == 1) | (digito == 2) | (digito == 3) | (digito == 4) | (digito == 5) | (digito == 6) | (digito == 7) | (digito == 8) | (digito == 9))
                {
                    digitocorrecto = true;
                }
            } while (digitocorrecto == false);

           

            primerarray = new int[longitud];
            segundoarray = new int[longitud];
            

            miarray.Rellenarvalores(primerarray, min, max);
           
            
            for (int i = 0; i < primerarray.Length; i++)
            {
                if (primerarray[i] % 10 == digito)
                {
                    segundoarray[i] = primerarray[i];
                    Console.WriteLine(primerarray[i]);
                }
                
            }
        }
    }
}
