
#region Before



//double getArea(object[] shapes)
//{
//    double totalArea = 0;

//    foreach (var shape in shapes)
//    {
//        if (shape is Rectangle)
//        {
//            Rectangle rectangle = (Rectangle)shape;
//            totalArea += rectangle.Width * rectangle.Height;
//        }
//        else
//        {
//            Circle circle = (Circle)shape;
//            totalArea += circle.Radious * circle.Radious * Math.PI;
//        }
//    }
//    return totalArea;
//}


//public class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//}

//public class Circle
//{
//    public double Radious { get; set; }
//}

#endregion
//If we have to calculate another type of object (say, Trapezium) then we’ve to add another condition.
//But from the rules of OCP,we have an idea that Software entities should be closed for modification.
//Hence it violates OCP. 


#region After

//double getArea(shape[] shapes)
//{
//    double totalArea = 0;
//    foreach (var shape in shapes)
//    {
//        totalArea += shape.Area();
//    }

//    return totalArea;
//}

//public abstract class shape
//{
//    public abstract double Area();
//}

//public class Rectangle : shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public override double Area()
//    {
//        return Width * Height;
//    }
//}

//public class Circle : shape
//{
//    public double Radious { get; set; }

//    public override double Area()
//    {
//        return Radious * Radious * Math.PI;
//    }
//}


#endregion
//Now if we have to calculate another type of object, we don’t have to alter logic (in getArea()),
//we just have to add another class like Rectangle or Circle.