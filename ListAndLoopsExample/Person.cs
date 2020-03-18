using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class Person
    {
        public string etunimi;
        public string sukunimi;
        public int numero;
        public string email;

        public Person(string etunimi, string sukunimi, int numero, string email)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.numero = numero;
            this.email = email;
        }


    }
}
//Person = luokka - etunimi, sukunimi, puhelin numero, email