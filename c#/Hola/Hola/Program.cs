using System;

namespace Hola
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal suma;
            decimal x;
            decimal num;
            Console.WriteLine("Introduzca un numero para sumar:  ");
            num = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca un numero para sumar:  ");
            x = decimal.Parse(Console.ReadLine());
            suma = num + x;
            Console.WriteLine("La suma es: " + suma);
        }
    }
}
