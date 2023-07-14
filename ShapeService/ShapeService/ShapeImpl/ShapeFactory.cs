namespace ShapeService.ShapeImpl
{
    public class ShapeFactory
    {
        public IShape SelectShape(string type,double length1, double length2, double length3)
        {
            //factory method for creatng objects

            IShape shape = null;
            if (type.ToLower().Equals("circle"))
            {
                shape = new Circle(length1);
            }
            else if (type.ToLower().Equals("rectangle"))
            {
                shape = new Rectangle(length1, length2);
            }
            else if (type.ToLower().Equals("triangle"))
            {
                shape = new Triangle(length1, length2, length3);
            }
            return shape;
        }
    }
}