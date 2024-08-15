using System;
using System.Globalization;

namespace MeuPrograma
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2;
            circulo = 3.14159 * (c * c);
            trapezio = (a + b) * c / 2;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine($"Triângulo: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Círculo: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapézio: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retângulo: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
