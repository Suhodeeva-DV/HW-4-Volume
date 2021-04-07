using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_Volume
{
    public abstract class Shape
    {
        public abstract double Valume();
        public abstract string Name();
    }

    public class Box : Shape
    {
        public int Height { get; set; }

        public override string Name()
        {
            return "Куб";
        }

        public override double Valume()
        {
            return Math.Pow(Height, 3);
        }

        public bool Add (double ValumeBox, double Valume2)
        {
            if (Valume2 > ValumeBox)
            {
                return false;
            }
            else return true;
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

        public override double Valume()
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

        public override double Valume()
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

        public override double Valume()
        {
            return (4 * Math.PI * Math.Pow(Radius, 3) / (double)3);
        }
    }
}
