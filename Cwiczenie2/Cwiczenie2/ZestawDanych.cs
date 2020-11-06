using System;
using System.Collections.Generic;
using System.Text;

namespace Cwiczenie2
{

 public class ZestawDanych
    {
        public string indexNumber;
        public string fname;
        public string lname;
        public string birthdate;
        public string email;
        public string mothersName;
        public string fathersName;
        public string studiesName;
        public string studiesMode;

        public string[] zestawDanych;
        public int iloscKolumn;
    
    public ZestawDanych(string [] zestawDanych)
    {
            iloscKolumn = 9;
            if(zestawDanych.Length!= iloscKolumn)
            {
                throw new Exception("Zła ilośc dostarczonych do konstruktora danych");
            }
            else
            {
                this.zestawDanych = zestawDanych;
            }

            Console.WriteLine(" Obiekt został stworzony ");



        }




        public void showZestawDanych()
        {

            int count = 0;

            foreach( string s in zestawDanych)
            {
                count++;

                Console.WriteLine(" Kolumna " + count + ": " + s);

            }






        }


}

}
