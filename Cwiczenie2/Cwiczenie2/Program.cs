using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Schema;

namespace Cwiczenie2
{
    class Program
    {
     

        public enum FormatDanych
        {
            xml,
            json
        };

        static void Main(string[] args)
        {

            // 1. pobieram plik cvs istniejacy na komputerze 

            Console.WriteLine("pobieram plik cvs istniejacy na komputerze");
            PlikWejsciowy plikWejsciowy = new PlikWejsciowy(@"dane.csv");
            Console.WriteLine("wyswietlam zawartosc pliku na ekran");
          //plikWejsciowy.showContent();


            //2. pobierz dane z pliku cvs i przechowaj w zmiennej
            Console.WriteLine("pobierz dane z pliku cvs i przechowaj w zmiennej");
            List<string> listaZPliku = plikWejsciowy.getContent();
            Console.WriteLine("sprawdzamy przypisany do listy pobrany content  ");
            foreach(string s in listaZPliku)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("pobierz falszywe cvs i przechowaj w zmiennej");
            listaZPliku = plikWejsciowy.getFalseContent();
            Console.WriteLine("sprawdzamy przypisany do listy pobrany content  ");
            foreach (string s in listaZPliku)
            {
                Console.WriteLine(s);
            }


            // 3. Przeszukaj dane  z listy w poszukiwaniu zestawów danych studenta

            Console.WriteLine("Przeszukaj dane  z listy w poszukiwaniu zestawów danych studenta");

            DaneStudentow daneStudentow = new DaneStudentow(listaZPliku);
            //  List<ZestawDanych> zestawDanych =daneStudentow.extractData(listaZPliku);

            //    daneStudentow.setZestawyDanych(zestawDanych);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            Console.WriteLine("Sprawdz zapisane dane ");
            daneStudentow.showData();







        }








    }

    }








        
      



       



