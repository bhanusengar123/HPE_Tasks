using System;
using System.Collections.Generic;
using System.Text;
using static Area.Program;

namespace Area
{
    public abstract class Shape
    {
        public abstract double ShapeArea();

    }

    public class Triangle : Shape
    {
        private int _h, _b;
        public int Height
        {
            get
            {
                return _h;
            }
            set
            {
                if (value <= 0)
                    log.Error("Invalid Height");
                _h = value;
            }
        }

        public int Base
        {
            get
            {
                return _b;
            }
            set
            {
                if (value <= 0)
                    log.Error("Invalid Base");
                _b = value;
            }
        }
        public override double ShapeArea()
        {

            Console.WriteLine("Enter height");
            Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter base");
            Base = Convert.ToInt32(Console.ReadLine());

            double area = 0.5 * Base * Height;

            Console.WriteLine($"Area of Triangle is : {area}\n");

            return area;
        }
    }

    public class Rectangle : Shape
    {
        private int _length, _width;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                    log.Error("Invalid Length");
                _length = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                    log.Error("Invalid Width");
                _width = value;
            }
        }
        public override double ShapeArea()
        {
            Console.WriteLine("Enter length");
            Length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width");
            Width = Convert.ToInt32(Console.ReadLine());

            double area = Length * Width;

            Console.WriteLine($"Area of Rectangle is : {area}\n");

            return area;
        }
    }
}
