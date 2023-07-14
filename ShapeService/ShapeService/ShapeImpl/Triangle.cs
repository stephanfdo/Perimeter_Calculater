using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeService.ShapeImpl
{
    public class Triangle : IShape
    {
        protected double length1;
        protected double length2;
        protected double length3;

        public Triangle(double length1,double length2, double length3)
        {
            this.length1 = length1;
            this.length2 = length2; 
            this.length3 = length3; 
        }

        //calculate perimeter of a triangle
        public double ComputePerimeter()
        {
            return length1 + length2 + length3;
        }
    }
}