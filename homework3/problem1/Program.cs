using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
   interface Shape
    {
        void Display();
        double getArea();
   }

    public class rectangle : Shape
    {
        private double myWidth;
        private double myHeight;
        private double myArea;
        public rectangle(double width, double height)
        {
            myWidth = width;
            myHeight = height;
            myArea = width * height;
        }
        public  double getArea()
        {
            return myArea;
        }
        public  void Display()
        {
            Console.WriteLine("Area is " + myArea);
            for (int i=0; i < (int)myHeight; i++)
            {
                for(int j=0; j < (int)myWidth; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }

    public class triangle : Shape
    {
        private double myWidth;
        private double myHeight;
        private double myArea;
        public triangle(double width, double height )
        {
            myWidth = width;
            myHeight = height;
            myArea = width * height/2;
        }
        public double getArea()
        {
            return myArea;
        }
        public  void Display()
        {
            Console.WriteLine("Area is "+myArea);
        }
    }

    public class Circle : Shape
    {
        private double myRadius;
        private double myArea;
        public Circle(double radius)
        {
            myRadius = radius;
            myArea = radius * radius*3.14;
        }
        public  double getArea()
        {
            return myArea;
        }
        public  void Display()
        {
            Console.WriteLine("Area is " + myArea);
        }
    }

    public class Square : Shape
    {
        private double myWidth;
        private double myArea;
        public Square(double width)
        {
            myWidth = width;
            myArea = width * width;
        }
        public  double getArea()
        {
            return myArea;
        }
        public  void Display()
        {
            Console.WriteLine("Area is " + myArea);
            for (int i = 0; i < (int)myWidth; i++)
            {
                for (int j = 0; j < (int)myWidth; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }

    class ChartFactory
    {
        //静态工厂方法  
        public static Shape getChart(String type)
        {
            Shape chart = null;
            if (type.CompareTo("Square")==0)
            {
                chart = new Square(5);
            }
            else if (type.CompareTo("rectangle") == 0)
            {
                chart = new rectangle(5,3);
            }
            else if (type.CompareTo("triangle") == 0)
            {
                chart = new triangle(5,3);               
            }
            else if (type.CompareTo("Circle") == 0)
            {
                chart = new Circle(3);
            }
            chart.Display();
            return chart;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape b = ChartFactory.getChart("Square");
        }
    }
}


