using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var Man = new Man();
            var Kart = new Kart();
            var Alien = new Alien();

            


        }
    }

    //ObjectThatMovesAndHasColor
    public class GeneralObject
    {
        public GeneralObject()
        {

        }
        
        public bool moves { get; set; }
        public string color { get; set; }

    }

        public class Human : GeneralObject
        {
             public Human()
            {

            }
            public string name { get; set; }
        }


            //when you create a Man, it will first look at GeneralObject and steal all its properties and put it inside Man
            public class Man : Human
            {
                public Man( )
                {       
        
                }
                //everything that uses this blueprint can use the property color
            }


            public class Women : Human
            {
                public Women()
                {

                }


    public class Kart : GeneralObject
    {
        public Kart()
        {

        }
        public string manufacturer { get; set; }
    }


    public class Alien : GeneralObject
    {
        public Alien()
        {

        }
        public string planet { get; set; }
    }

}
