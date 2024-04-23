using System;

namespace ExercicioFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Digite largura e altura: ");
            rectangle.Width = double.Parse(Console.ReadLine());
            rectangle.Height = double.Parse(Console.ReadLine());

            rectangle.calculateArea();
            rectangle.calculatePerimeter();
            rectangle.calculateDiagonal();
        }
    }
}