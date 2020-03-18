using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class DataHandler
    {



            public List<Coffee> coffees = new List<Coffee>();
            public List<Person> person = new List<Person>();

        public Coffee CreateCoffee()
        {
            Console.WriteLine("Anna kahvin merkin");
            var merkki = Console.ReadLine();
            var hinta = Console.ReadLine();
            var paahto = Console.ReadLine();

            //syötä hinta ja paahto (1-5)
            //ei comppany
            Coffee toReturn = new Coffee(merkki,hinta,paahto);
            toReturn.roast = (Coffee.Roast)2;
            return toReturn;
        }




        //metodi joka tuo persoonan
    }
}
//DataHandler - luokka, list<coffee>, list<person>