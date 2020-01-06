//this program uses inheritence in order to use the color and 'moves' properties located in GeneralObject inside all other classes

using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
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

    //when you create a Man, it will first look at GeneralObject and steal all its properties and put it inside Man
    public class Man : GeneralObject
    {
        public Man( )
        {
            var Man = new Man();
            var Kart = new Kart();
            var Alien = new Alien();
           
        }
        //everything that uses this blueprint can use the property color
        public string name { get; set; }
    }

    public class Kart : GeneralObject
    {
        public Kart()
        {
        public string manufacturer { get; set; }
    }


    public class Alien : GeneralObject
    {
        public Alien()
        {
        public string planet { get; set; }
    }

}
