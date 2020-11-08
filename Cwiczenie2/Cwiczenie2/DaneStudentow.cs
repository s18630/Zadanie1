using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Cwiczenie2
{
public   class DaneStudentow   
  
    {
        public List<ZestawDanych> zestawDanychStudentow { get; set; }
        public SpisBledow spisBledow;


        public DaneStudentow(List<string> lista)
        {
            zestawDanychStudentow = new List<ZestawDanych>();
            spisBledow = new SpisBledow();
            extractData(lista);


        }

        public void extractData(List<string> lista)
        {
            int iloscposprawdzeniu = 0;
            int iloscrekordowWejsciowych = lista.Count;

            
            foreach (string s in lista)
            {
 
                string[] studentsData = s.Split(',');


                try
                {
                   
                    zestawDanychStudentow.Add(new ZestawDanych(studentsData));

                    iloscposprawdzeniu++;

                }
                catch (Exception ex)
                {

                    DateTime dt= DateTime.Today;
                  
                    spisBledow.zapiszDoPliku("ZAPIS : " + dt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR")) +
                        "\nBłąd w dodawaniu zestawu danych :\n " + s);
                    string message = ex.Message;
                    spisBledow.zapiszDoPliku("bład : " + message + "\n");


                    Console.WriteLine(" Bład w tworzeniu zestawu danych");
                    Console.WriteLine(ex.Message + "\n");

                }

            }
            Console.WriteLine(" przed "+ iloscrekordowWejsciowych + "->"+"po "+ iloscposprawdzeniu);

        }


        public void showData()
        {
            if (zestawDanychStudentow.Count == 0)
            {
                Console.WriteLine("Lista jest pusta ");
            }
            else
            {

                Console.WriteLine(" Dostepne dane:");

                int i = 0;

                foreach (ZestawDanych zestawDanych in zestawDanychStudentow)
                {  i++;
                    Console.WriteLine(" Zestaw Danych nr " + i);
                  

                    zestawDanych.showZestawDanych();


                    Console.WriteLine();
                }

                Console.WriteLine("Zostało zapisane " + i + "zestawów danych");


            }

            


        }

    }
}
