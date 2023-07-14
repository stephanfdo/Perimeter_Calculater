using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeService.ShapeImpl
{
    public class Circle : IShape 
    {
        protected double radius; 
        
        public Circle (double radius)
        {
            this.radius = radius; 
        }

        //calculate perimeter of a circle
        public double ComputePerimeter()
        {
            double pi = Math.PI;
            return radius * 2 * pi;
        }
    }
}