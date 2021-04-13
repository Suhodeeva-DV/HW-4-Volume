using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_Volume
{
    public abstract class Shape
    {
        public abstract double Volume();
        public abstract string Name();
    }

    public class Box : Shape
    {
        public int Height { get; set; }
        public List<Shape> elementsInBox = new List<Shape>();
        public double FilledVolume;

        public override string Name()
        {
            return "Куб";
        }

        public override double Volume()
        {
            return Math.Pow(Height, 3);
        }


        public bool Add(Shape shape)
        {
            double remainingVolume = Volume() - FilledVolume;
            double shapeVolume = shape.Volume();

            if (remainingVolume >= shapeVolume)
            {
                elementsInBox.Add(shape);
                FilledVolume += shapeVolume;
                return true;
            }
            else
            {
                Console.WriteLine($"Данное тело (V = {shape.Volume()}) не помещается в Box.");

                Console.WriteLine();

                Console.WriteLine("Содержимое Box: ");

                foreach (Shape k in elementsInBox)
                {
                    Console.WriteLine($"{k.Name()}, V = {k.Volume()}");
                }

                return false;
            }
        }
    }



    public class Cylinder : Shape
    {
        public int Radius { get; set; }
        public int Height { get; set; }

        public override string Name()
        {
            return "Цилиндр";
        }

        public override double Volume()
        {
            return (Math.PI * Radius * Radius * Height);
        }
    }

    public class Pyramid : Shape
    {
        public int Area { get; set; }
        public int Height { get; set; }

        public override string Name()
        {
            return "Пирамида";
        }

        public override double Volume()
        {
            return (Area * Height / (double)3);
        }
    }

    public class Ball : Shape
    {
        public int Radius { get; set; }

        public override string Name()
        {
            return "Шар";
        }

        public override double Volume()
        {
            return (4 * Math.PI * Math.Pow(Radius, 3) / (double)3);
        }
    }
}
