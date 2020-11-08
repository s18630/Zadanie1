using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cwiczenie2
{

 public class ZestawDanych
    {
        public string[] zestawDanych;
        public int iloscKolumn;
       

        public ZestawDanych(string [] zestawDanych)
    {
            iloscKolumn = 9;
            if(zestawDanych.Length!= iloscKolumn)
            {
                throw new Exception("Zła ilośc dostarczonych do konstruktora danych");
                
            }
            if (zawieraPustePole(zestawDanych))
            {

                throw new Exception(" Jenda z kolumn nawiera nieprawidłową wartość");
                
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





        public bool isItEmpty(string pole)
        {
            return  !(Regex.IsMatch(pole , "[a-z0-9]+", RegexOptions.IgnoreCase));
            
        }

        public bool zawieraPustePole( string [] pola  )
        {
            int nrKolumny = 0;
            foreach( string s in pola)
            {
                nrKolumny++;

                if (isItEmpty(s) == true)
                {
                    Console.WriteLine(" Niepasujące pole w kolumnie " + nrKolumny);
                    return true;
                    
                }



            }

            return false;
        }

        public string [] getZestawDanych()
        {
            return zestawDanych;
        }
}

}
