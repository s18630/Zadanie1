using System;
using System.Collections.Generic;
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



            Console.WriteLine("LISYA ARGUMENÓW " + args.Length);

            SpisBledow zapisBledow = new SpisBledow();

            //gdy nei dostawczono argumentow
            if ( args.Length == 0)
            {


                zapisBledow.zapiszDoPliku(" Nie dostarczono argumentów ");
                PlikWejsciowy pw = new PlikWejsciowy();
                DaneStudentow ds = new DaneStudentow(pw.content);
                ListaStudentow ls = new ListaStudentow(ds.zestawDanychStudentow);
                List<Student> list = ls.listaStudentow;
                List<string> lista = ls.listaStudent;
                PlikWyjsciowy pwyj = new PlikWyjsciowy(lista);

            }



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



            string path = @"C:\Users\weron\OneDrive\Pulpit\plikdoTestó\TEST.csv";
            if (File.Exists(path))
            {
                Console.WriteLine("sciezka istnieje");
            }
            else
            {
                Console.WriteLine("sciezka NIEnieje");
            }

           


    //      Console.WriteLine(czySciezkaCVS("C:\Users\weron\OneDrive\Pulpit\plikdoTestó\TEST.csv"));





            if (args.Length <= 3 && args.Length >0)
            {
                string sciezka = @"data.csv";



                foreach (string s in args)
                {





                    Console.WriteLine();

                    Console.WriteLine();

                    bool konsowka = s.EndsWith(".csv");
                    bool koncewkazaprostrofem = s.EndsWith(".csv" + '\u0022');

                    if (konsowka == true || koncewkazaprostrofem == true)
                    {
                        if(konsowka == true)
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

                    






                }var replacement = sciezka.Replace("data.csv", sciezka);
                    Console.WriteLine("Zastopiona ściezka:" + replacement);
                    Console.WriteLine("WYNIKOWA SCIEZKA" + replacement);


                    Console.WriteLine("UWAGA SPRAWDZAM CZY SCIEZKA ISTNIEJE");

                    if (File.Exists(sciezka))
                    {
                        Console.WriteLine("sciezka istnieje");
                    }
                    else
                    {
                        Console.WriteLine("sciezka NIEnieje");
                    }





                PlikWejsciowy plikWejściowy;

                try
                {


                   plikWejściowy = new PlikWejsciowy(sciezka);

                }
                catch (Exception ex)
                {
                    zapisBledow.zapiszDoPliku("Nie udało się stworzyć pliku Wejściowego z podanej ścieżki");
                    Console.WriteLine(ex.Message);
                    zapisBledow.zapiszDoPliku(ex.Message);
                    plikWejściowy = new PlikWejsciowy();

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

            return false;
        }



     



        public static bool czyFormat(string argument)
        {
            if (argument.Equals("XML", StringComparison.OrdinalIgnoreCase)
                || argument.Equals("JSON", StringComparison.OrdinalIgnoreCase))

            {
                return true;
            }
            return false;


        }






        
  




            










        } 




    }




























   
          








































    
    









































        
      



       



