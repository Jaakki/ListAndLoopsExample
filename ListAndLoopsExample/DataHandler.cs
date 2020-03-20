using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class DataHandler
    {

            //change

            public List<Coffee> coffees = new List<Coffee>();
            public List<Person> person = new List<Person>();

        public Coffee CreateCoffee()
        {
            Console.WriteLine("Anna kahvin merkin");
            var merkki = Console.ReadLine();
            Console.WriteLine("Anna kahvin hinta");
            double hinta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Anna kahvin paahto");
            int paahto = int.Parse(Console.ReadLine());
            Comppany importer = null;
            //syötä hinta ja paahto (1-5)
            //ei comppany
            Coffee toReturn = new Coffee(merkki, hinta, paahto, importer);
            toReturn.roast = (Coffee.Roast)2;
            return toReturn;
        }




        //metodi joka tuo persoonan
    }
}
//DataHandler - luokka, list<coffee>, list<person>