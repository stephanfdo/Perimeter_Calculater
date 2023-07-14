using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ShapeService.ShapeImpl;

namespace ShapeService
{
    /// <summary>
    /// Summary description for ShapeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ShapeService : System.Web.Services.WebService
    {
        [WebMethod]
        public double ComputePerimeter(string type, double length1, double length2, double length3)
        {
            //select shape type , return perimeter of shape
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape = shapeFactory.SelectShape(type, length1, length2, length3);

            //get instance from logger

            Logger logger = Logger.getInstance();

            //passing data in to logger 

            logger.writingLog(type, shape.ComputePerimeter());

            return shape.ComputePerimeter();
        }
    }
}
