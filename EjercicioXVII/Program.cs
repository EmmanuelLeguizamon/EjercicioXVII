using System;

namespace EjercicioXVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Ingrese un número: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            b = Int32.Parse(Console.ReadLine());
            double resultado = Math.Pow(a,b);

            Console.WriteLine("La suma de los 2 numeros es: " + (a + b));
            Console.WriteLine("La resta de los 2 numeros es: " + (a - b));
            Console.WriteLine("La multiplicación de los 2 numeros es: " + (a * b));
            Console.WriteLine("La división de los 2 numeros es: " + (a / b));
            Console.WriteLine("El resto de la división de los 2 numeros es: " + (a % b));
            Console.WriteLine("La potencia de los 2 numeros es: " + (resultado));

        }
    }
}
