﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cwiczenie2
{
public  class SpisBledow
    {

        public string nazwaPliku;
        public string sciezka;


        public SpisBledow()
        {
            nazwaPliku = "łog.txt";
            sciezka = @"łog.txt";


      
            utworzPlik();

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR")));


            zapiszDoPliku("Utworzono Plik ");
            zapiszDoPliku(dt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR")));

            Console.WriteLine("Utworzono Plik ");
            Console.WriteLine(dt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR")));
        }







              public void otworzPlik()
              {
                  try
                  {
                
                using (var sr = new StreamReader(nazwaPliku))
                {
                   
                    Console.WriteLine(sr.ReadToEnd());
                }
                  }
                  catch (IOException e)
                  {
                      Console.WriteLine("The file could not be read:");
                      Console.WriteLine(e.Message);
                  }
              }
        

        // wyswietl sciezke do pliku 


        public void utworzPlik()
        {


            Console.WriteLine("Path to my file: {0}\n", sciezka );

        
            if (!System.IO.File.Exists(sciezka))
            {

                using (System.IO.FileStream fs = System.IO.File.Create(sciezka))
                {
                    Console.WriteLine(" Stworzono plik ");
                }

            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", nazwaPliku);
                return;
            }

        }



        public void zapiszDoPliku(string napis)
        {
            try
            {

                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(sciezka, true))
                {
                    file.WriteLine(napis);
                }

            }
            catch (Exception Ex)
            {

                Console.WriteLine("File \"{0}\" nie istnieje", nazwaPliku);

            }






        }



    }
}
