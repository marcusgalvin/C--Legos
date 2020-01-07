using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.count(4);
            worker.count(5);

            worker.count(4.5f);
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }
        //only uses float when something in main is calling float
        public void count(int number)
        {
            if (Total == null)
                Total = 0;

            Total = Total + Convert.ToSingle(number);
            Console.WriteLine(Total.ToString()); 

            

        }

        public void count(float number)
        {
            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }


        public void count(int num1, float num2, double num3)
        {
            //code to add all 3
        }

        public float Total { get; set; }
    }

}
