using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePuzzleBusinessServices
{
    public class Shape
    {
        public string ShapeName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int SideLength { get; set; }
        public int Radius { get; set; }

        // Virtual method
        public virtual void Draw()
        {
            //Performing base class drawing tasks
        }
    }

    public class Circle : Shape
    {       
        public override void Draw()
        {
            base.Draw();
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            base.Draw();
        }
    }

    public class IsoscelesTriangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
        }
    }

    public class ScaleneTriangle : Shape
    {
        public override void Draw()
        {            
            base.Draw();
        }
    }

    public class Parallelogram : Shape
    {
        public override void Draw()
        {
            base.Draw();
        }
    }

    public class EquilateralTriangle : Shape
    {
        public override void Draw()
        {            
            base.Draw();
        }
    }

    public class Pentagon : Shape
    {
        public override void Draw()
        {
            base.Draw();
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
        }
    }

    public class Hexagon : Shape
    {
        public override void Draw()
        {
            base.Draw();
        }
    }

    public class Heptagon : Shape
    {
        public override void Draw()
        {
            base.Draw();
        }
    }

    public class Octagon : Shape
    {
        public override void Draw()
        {
            base.Draw();
        }
    }

    public class Oval : Shape
    {
        public override void Draw()
        {
            base.Draw();
        }
    }

}
