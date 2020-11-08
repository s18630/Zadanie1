using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;



namespace Cwiczenie2
{
    class Program
    {




        static void Main(string[] args)
        {



            Console.WriteLine("Ilość podanych argumentów :" + args.Length);

            SpisBledow zapisBledow = new SpisBledow();
            DateTime dt = DateTime.Now;
            string dataString = dt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR"));
            zapisBledow.zapiszDoPliku("\n ROZPOCZĘTA EDYCJA PLIKU\n " + dataString + "\n");



            //gdy nie dostarczono argumentów
            if (args.Length == 0)
            {


                zapisBledow.zapiszDoPliku(" Nie dostarczono argumentów ");
                PlikWejsciowy pw = new PlikWejsciowy();
                DaneStudentow ds = new DaneStudentow(pw.content);
                ListaStudentow ls = new ListaStudentow(ds.zestawDanychStudentow);
                List<Student> list = ls.listaStudentow;
                List<string> lista = ls.listaStudent;
                PlikWyjsciowy pwyj = new PlikWyjsciowy(lista);

            }
            /////////////////////////////////////////////////////////

            //gdy dostarczono za duzo argumentów

            if (args.Length > 3)
            {


                zapisBledow.zapiszDoPliku(" Dostarczono za dużo argumentow");
                PlikWejsciowy pw = new PlikWejsciowy();
                DaneStudentow ds = new DaneStudentow(pw.content);
                ListaStudentow ls = new ListaStudentow(ds.zestawDanychStudentow);
                List<Student> list = ls.listaStudentow;
                List<string> lista = ls.listaStudent;
                PlikWyjsciowy pwyj = new PlikWyjsciowy(lista);

            }


            /////////////////////////////////////////////////////////
            //Przeszukujemy dostarczone parametry czy jest plik csv



            string sciezka = @"data.csv";

            if (args.Length <= 3 && args.Length > 0)
            {



                foreach (string s in args)
                {



                    bool konsowka = s.EndsWith(".csv");
                    bool koncewkazaprostrofem = s.EndsWith(".csv" + '\u0022');

                    if (konsowka == true)
                    {

                        Console.WriteLine("rowna się true" + s);
                        sciezka = s;

                    }

                    if (koncewkazaprostrofem == true)
                    {
                        var replace = s.Replace("\u0022", "");
                        Console.WriteLine("Zastopiona ściezka:" + replace);
                        sciezka = replace;
                    }




                }
                //zamieniamy sciezke z domyślną



                var replacement = sciezka.Replace("data.csv", sciezka);
                Console.WriteLine("Zastopiona ściezka:" + replacement);
                Console.WriteLine("WYNIKOWA SCIEZKA" + replacement);


                Console.WriteLine("UWAGA SPRAWDZAM CZY SCIEZKA ISTNIEJE");
                //// sprawdzamy czy sciezka istnieje jesli nie zapisujemy bład do pliku
                ///

                try
                {
                    bool czySciezkaIstnie = czyPlikIstnieje(sciezka);
                    if (czySciezkaIstnie == true)
                    {
                        sciezka = replacement;
                        Console.WriteLine("sciezka istnieje");

                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("sciezka nie istnieje");

                    zapisBledow.zapiszDoPliku(ex.Message + "\nPosana ścieżka nie istnieje:" + sciezka);


                }







                ////////////////////////////////////



                PlikWejsciowy plikWejściowy;

                try
                {
                    Console.WriteLine(" Próba stworzenia pliku");

                    plikWejściowy = new PlikWejsciowy(sciezka);
                    Console.WriteLine(" Próba stworzeny");
                    //   plikWejściowy.showContent();

                }
                catch (Exception ex)
                {
                    zapisBledow.zapiszDoPliku("Nie udało się stworzyć pliku Wejściowego z podanej ścieżki");
                    Console.WriteLine(ex.Message);
                    zapisBledow.zapiszDoPliku(ex.Message);
                    plikWejściowy = new PlikWejsciowy();

                }

                DaneStudentow ds = new DaneStudentow(plikWejściowy.content);
                ListaStudentow ls = new ListaStudentow(ds.zestawDanychStudentow);
                List<Student> list = ls.listaStudentow;
                List<string> lista = ls.listaStudent;


                /////////////////////////////////////////////////////////

                // Mamy teraz plik wejściowy i przechowane dane, teraz gdzie je zapisać





                //przeszukuje podane argumenty czy jest ścieżka docelowa

                string sciezkaDocelowa = @"żesult.xml";
                foreach (string s in args)
                {



                    bool konsowka = s.EndsWith(".xml");
                    bool koncewkazaprostrofem = s.EndsWith(".xml" + '\u0022');

                    if (konsowka == true)
                    {

                        Console.WriteLine("rowna się true" + s);
                        sciezkaDocelowa = s;

                    }

                    if (koncewkazaprostrofem == true)
                    {
                        var replace = s.Replace("\u0022", "");
                        Console.WriteLine("Zastopiona ściezka:" + replace);
                        sciezkaDocelowa = replace;
                    }




                }


                try
                {

                    if (czySciezkaDocelow(sciezkaDocelowa))
                    {
                        Console.WriteLine("scieżka docelowa -> " + sciezkaDocelowa + " jest poprawna");


                        // sprawdzam teraz co z formatem danych 






































































                    }

                }
                catch (Exception ex)
                {
                    zapisBledow.zapiszDoPliku("Podana ścieżka nie jest poprawna ");
                    Console.WriteLine(ex.Message);
                    zapisBledow.zapiszDoPliku(ex.Message);



                }

















                // sprawdzamy dostarczone argumenty czy 


                PlikWyjsciowy pwyj;

                bool czyUtworzonoPlik = false;

                foreach (string s in args)
                {


                    if (s.Equals("XML", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(" znaleziono " + s);

                        pwyj = new PlikWyjsciowy(lista, s);
                        czyUtworzonoPlik = true;

                    }




                    /*      if(s.Equals("JSON", StringComparison.OrdinalIgnoreCase))

                        {
                            Console.WriteLine(" znaleziono " + s);
                            Console.WriteLine(" Nie można utworzyć pliku tego fromaty");
                            zapisBledow.zapiszDoPliku(" Nie można utworzyć pliku tego fromaty: " + s);
                            //  pwyj = new PlikWyjsciowy(lista, s)
                            czyUtworzonoPlik = true;

                        }*/

                    /*
                                    }
                                    if( czyUtworzonoPlik == false)
                                    {

                                        Console.WriteLine(" Nie znaleziono odpowiedniego fotmatu " +
                                            "zostanei wygenerowany domyślny plik");
                                        zapisBledow.zapiszDoPliku(" Nie znakeziono odpowiedniego fromatu    ");

                                    }



                                } */



                    //         pwyj = new PlikWyjsciowy(lista);























































































                }

            }
        }



        public static bool czySciezkaDocelow(string argument)
        {

            if (argument.EndsWith(".xml")
                || argument.EndsWith(".json"))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Podana ścieżka jest niepoprawna");

            }

            
        }


        public static bool czyPlikIstnieje(string sciezka) {

            if (File.Exists(sciezka))
            {
                Console.WriteLine("sciezka istnieje");
                return true;

            }
            else
            {
                Console.WriteLine("sciezka nie istnieje");
                throw new FileNotFoundException("Plik nazwa nie istnieje");
            }


}













    }





}




            














   



























   
          








































    
    









































        
      



       



