/* using System;
namespace WorkDraft
{
    class Rectangle
    {
        protected double length;
        protected double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double getArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Width = {0}, Length = {1}, Area = {2}",
                             width, length, getArea());
        }
    }

    class Tablet : Rectangle
    {
        private double cost;

        public Tablet(double l, double w) : base(l, w) { }

        public double getCost()
        {
            cost = 70 * getArea();
            return cost;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", getCost());
        }
    }

    class ExecuateRectangle
    {
        static void Main(string[] args)
        {
            Tablet t = new Tablet(4.5, 7.5);
            t.Display();
        }
    }
}
 */