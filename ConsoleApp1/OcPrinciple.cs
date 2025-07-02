using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
//open/closed Priciple
namespace OopsAndSolidPrinciples
{
    //abstract class Shape to calculate the area
    public abstract class Shape
    {
        public abstract double CalculateTheAreaOfShape();
    }

    //Rectangle class 
    public class Rectangle : Shape
    {
        //fields
        public double Width { get; set; }
        public double Height { get; set; }

        //methode to calculate the area of rectangle
        public override double CalculateTheAreaOfShape()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        //properties
        public double Radius { get; set; }

        //method to calculate the area of circle
        public override double CalculateTheAreaOfShape()
        {
            return Radius * Radius * Math.PI;
        }
    }

    //class to get the total area for all the shapes
    public class AreaCalculator
    {
        //method to calculate the total area.
        public double GetAreaOfShapes(Shape[] shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.CalculateTheAreaOfShape();
            }

            return totalArea;
        }
    }
}

