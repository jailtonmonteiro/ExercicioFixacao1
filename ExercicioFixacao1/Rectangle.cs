using System;
using System.Globalization;

namespace ExercicioFixacao1
{
    internal class Rectangle
    {
        double width, height, area, perimeter, diagonal;

        public void calculateArea()
        {
            area = width * height;
            Console.WriteLine($"AREA: {area.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public void calculatePerimeter()
        {
            perimeter = (width * 2) + (height * 2);
            Console.WriteLine($"PERIMETRO: {perimeter.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public void calculateDiagonal()
        {
            diagonal = Math.Sqrt((width * width) + (height * height));
            Console.WriteLine($"DIAGONAL: {diagonal.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public double Perimeter
        {
            get { return perimeter; }
            set { perimeter = value; }
        }
        public double Diagonal
        {
            get { return diagonal; }
            set { diagonal = value; }
        }
    }
}
