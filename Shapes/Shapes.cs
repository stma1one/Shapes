using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Shape
    {
        //members
        protected string name;
        protected string color;

        //constructors
        public Shape(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        //getters and setters
        public string GetName()
        { return name; }
        public string GetColor()
        {
            return color;
        }

        public void SetName(string name)
        { this.name = name; }

        public void SetColor(string color)
        {
            this.color=color;   
        }

    }

    public class Circle:Shape
    {
        private double radius;
        public Circle(double radius,string name,string color):base(name,color) 
        {
            this.radius = radius;
        }
        public Circle (double radius, string color):base("Circle",color)
            {
                this.radius = radius;
            }

        public double GetRadius()
        {
            return radius;  
        }

        public void SetRadius(double radius)
        {
            if(radius>=0)
            {
                this.radius = radius;
            }
        }

        public double Perimeter()
        {
            return 2*Math.PI*radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }


    }

    public class Rectangle:Shape
    {
        protected double width; 
        protected double height;

        public Rectangle(double width, double height,string color):base("Rectangle",color)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(double width,double height, string name, string color):base(name,color)
        {
            this.width = width;
            this.height = height;
        }

        public double GetHeight()
        {
            return height;
        }
        public double GetWidth()
        {
            return width;
        }
        public double Area()
        {
            return width * height;
        }

        public double Perimeter()
        {
            return 2 * width + 2 * height;
        }
    }

    public class Square:Rectangle
    {
        public Square(double a,string color):base(a,a,"Square",color)
        { }
    }
}
