using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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














            PlikWejsciowy pw = new PlikWejsciowy();
            DaneStudentow ds = new DaneStudentow(pw.content);
            ListaStudentow ls = new ListaStudentow(ds.zestawDanychStudentow);
            List<Student> list = ls.listaStudentow;
            List<string> lista = ls.listaStudent;
            PlikWyjsciowy pwyj = new PlikWyjsciowy(lista, "sprawdzenie.xml", "xml");
            string[] ars = new string[2]

            {
                "ddddd",
                "sss.cvs" };

            Console.WriteLine(czySciezkaCVS(ars[1]));

            Console.WriteLine(czyFormat(ars[1]));
            Console.WriteLine(czyFormat("xml"));
            Console.WriteLine(czySciezkaDocelow(".xml"));






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



        public static bool czySciezkaCVS(string argument)
        {

            return argument.EndsWith(".cvs");

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






        public static void
            ZnajdxSciezkeCS(string[] argumenty)
        {
            int licznik = 0;
            int mazymalna = argumenty.Length;

            if (argumenty.Length == 0)
            {
                throw new Exception(" Nie dostarczono żadnych parametrów");

            }

            foreach (string s in argumenty)
            {


                if (czySciezkaCVS(s) != true)
                {
                    licznik++;



                    if (licznik == mazymalna)
                    {
                        throw new Exception(" Nie podano ścieżki do pliku csv, użyta zostanie domyślna");

                    }

                }
                else
                {

                }




            }




        }
        public static void sprawdźArgumenty(string[] args)
        {

            SpisBledow sp = new SpisBledow();

            int liczbaArgumentow = args.Length;
            if (args.Length == 0)
            {
                sp.zapiszDoPliku(" Nie podano argumentów, będą wywołane argumenty domyślne ");
                throw new Exception(" Nie podano argumentów, będą wywołane argumenty domyślne ");
            }

            if (args.Length > 3)
            {
                sp.zapiszDoPliku(" Podano za dużo argumentów ");
                throw new Exception(" Podano za dużo argumentów ");

            }
            if (args.Length < 3)
            {
                sp.zapiszDoPliku(" Nie podano wszystkich 3 argumentów ");

                foreach (string s in args)
                {

                    bool czyACSV = czySciezkaCVS(s);
                   if(czyACSV == true)
                    {

                        try
                        {
                            PlikWejsciowy plikWejsciowy = new PlikWejsciowy(s);

                        }catch(Exception ex)
                        {
                            throw new Exception(" Nie udało się stworzyć pliku ");

                        }
     
                        




                    }

                }




            }










        }




    }
}



























   
          








































    
    









































        
      



       



