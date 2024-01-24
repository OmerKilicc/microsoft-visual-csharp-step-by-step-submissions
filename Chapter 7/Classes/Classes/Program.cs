using System;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            var origin = new Point();
            var bottom = new Point(2496, 1664);
            double distance = origin.DistanceTo(bottom);
            Console.WriteLine($"Distance is: {distance}");
            Console.WriteLine($"Numver of point objects is: {Point.ObjectCount()}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
