using System;
namespace MultiCasteDelegateDemo
{
    public delegate void RectDel(double Width, double Height); //defining delegate//step1

    public delegate void SquareDel(double Width, double Height);


    class Rectangle
    {
        public void Area(double Width, double Height) //Non-returning(value) methods)
        {
            Console.WriteLine(Width * Height);
        }
        public void Perimeter(double Width, double Height)
        {
            Console.WriteLine(2 * (Width + Height));
        }




    }

    class Square
    {
        public double GetArea(double Width, double Height) //returning(value) methods)
        {
            return= Width * Height;
        }
        public double GetPerimeter(double Width, double Height)
        {
            return= 2 * (Width + Height);
        }

    }
    class Test
    {
        static void Main()
        {
            Console.WriteLine("Let's learn about MultiCaste Delegate!\n");

            Rectangle rect = new Rectangle();
            // rect.Area(12.1, 50.3);
            // rect.Perimeter(12.1, 50.3);
            RectDel obj = new RectDel(rect.Area);//instatiation of the delegate//step2.
            obj += rect.Perimeter;

            obj.Invoke(12.1, 50.3);// this way one single delegate call will inke the two methods, as the both methods have same parameter types, same return types.(or same signature
            obj.Invoke(12.1, 60.3);//For another rectangle, area and parameters are found by single invoke call, single instance.

            // Square sq = new Square();//will return error
            //SquareDel obj2 = sq.GetArea;
            //obj2 += sq.GetPerimeter;
            //double result = obj2.Invoke(2.2, 3.3);
        }
    }
}
}
