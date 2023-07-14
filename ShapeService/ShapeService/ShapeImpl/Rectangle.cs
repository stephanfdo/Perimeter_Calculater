using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeService.ShapeImpl
{
    public class Rectangle : IShape  
    {
        protected double length;
        protected double width; 

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width; 
        }

        //calculate perimeter of a Rectangle
        public double ComputePerimeter()
        {
            return (length + width) * 2;
        }
    }
}