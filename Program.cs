using System;

namespace EJERCICIO_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALCULAR TIEMPO APROX EN LLEGAR
            //PASO 0: DECLARAR VARIABLES
            float D, V, T;

            //PASO 1: INGRESAR DATOS
            Console.WriteLine("Ingrese distancia recorrida: ");
            D = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese velocidad promedio: ");
            V = float.Parse(Console.ReadLine());

            //PASO 2: CALCULAR
            T = D / V;

            //PASO 3: MOSTRAR RESULTADO
            Console.WriteLine("El tiempo que se tarda es : " + T.ToString("0.00") + " horas");

        }
    }
}
