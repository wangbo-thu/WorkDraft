/* using System;

namespace WorkDraft
{
    class Shape
    {
        protected double width;
        protected double length;

        public void setWidth(double w)
        {
            width = w;
        }

        public void setLength(double l)
        {
            length = l;
        }
    }

    public interface PaintCost
    {
        double getCost(double area);
    }
    class Rectangle : Shape, PaintCost
    {
        public double getArea()
        {
            return length * width;
        }

        public double getCost(double area)
        {
            return area * 70;
        }
    }

    class RectangleTester 
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.setLength(5);
            Rect.setWidth(7);
            double area = Rect.getArea();

            Console.WriteLine("Total area: {0}", area);
            Console.WriteLine("Total cost: {0}", Rect.getCost(area));
        }
    }
} */