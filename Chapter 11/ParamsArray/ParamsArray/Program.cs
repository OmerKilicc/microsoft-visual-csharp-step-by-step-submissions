using System;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {

            Console.WriteLine(Utils.Sum(10,9));
            Console.WriteLine(Utils.Sum(1,1,2,3,4,5,6,7,8,9,0,8));
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
