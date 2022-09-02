using Capitulo10.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10.Entities
{
    class Rectangle:Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle() { }

        public Rectangle(double height, double width, Color color):base(color)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return (Height * Width);
        }
    }
}
