using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //create new dozer
            var dozer = new BullDozer("Yellow", "Mini");
            //can get rid of these lines below because of the constructor in the class BullDozer
            //dozer.color = "Yellow";
            //dozer.size = "mini";

            var dozer2 = new BullDozer("Red", "Large");
            //dozer.color = "Red";
            //dozer.size = "large";

            Console.WriteLine("BullDozer 1 is: " + dozer.color);
            Console.WriteLine("BullDozer 2 is: " + dozer2.color);

        }
    }

    //BullDozer class or blueprint
    public class BullDozer
    {
        public BullDozer (string _color, string _size)
        {
            //this refers to the BullDozer class
            this.color = _color;
            this.size = _size;
        }
        //everything that uses this blueprint can use the property color
        public string color { get; set; }
        public string size { get; set; }


    }
}
