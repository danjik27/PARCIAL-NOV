using System;

namespace DAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenos dias");
        //DECIMAL A BINARIO//
        const int est =2;
            int s =0;
            int l = 0;
            int c = 0;
            int I = 0;
            int [] VEC = new int[21];
            string linea;
            Console.Write("Ingrese cualquier Numero:");
            linea = Console.ReadLine();
             s = int.Parse(linea);
            c = 1;
            while ((s >= est))
            {
                l = s % est;
                VEC[c] = l;
                c = c + 1;
                s = s / est;
            }
            VEC [c] = s;
            
            for (I = c; I >= 1;I += -1)
            {
                Console.Write(VEC[I] + " ");
            }
        }
    }
}