using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        double height;
        double width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height
        {
            get => height;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative!");
                }
                height = value;
            }
        }
        public double Width
        {
            get => width;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative!");
                }
                width = value;
            }
        }
        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
