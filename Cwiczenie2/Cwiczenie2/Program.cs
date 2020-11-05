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
            string AdresPlikuCSV = "data.csv";
        string adresScieżkiDocelowej = "żesult.xml";
        FormatDanych formatDanych = FormatDanych.xml;
            Console.WriteLine(formatDanych);

            /*resPlikuCSV = args[0];
            adresScieżkiDocelowej = args[1];
            string xml= Enum.GetName(typeof(FormatDanych), 1);
            if(xml.Equals(args[3])== true)
            {
                formatDanych = FormatDanych.xml;
            } */

            string curFile = @"c:\temp\test.txt";
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
            curFile = @"dane.csv";
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");

            List<string> students =  new List<string>();


            using (StreamReader sr = File.OpenText(curFile))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    students.Add(s);
                    Console.WriteLine(s);
                }
            }


            Console.WriteLine("------------------------------------");
            foreach (string s in students)
            {

                Console.WriteLine(s);
             



            }
            Console.WriteLine("00000000000000000000000000000000000-");
            Console.WriteLine("00000000000000000000000000000000000-");
            Console.WriteLine("00000000000000000000000000000000000-");

            foreach (string s in students)
            {

                Console.WriteLine(s);

                string[] student = s.Split(',');
                Console.WriteLine(student[0]);
                Console.WriteLine(student[1]);
                Console.WriteLine(student[2]);
                Console.WriteLine(student[3]);




            };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SPRAWDZENIE KLASY");
            Console.WriteLine();
            PlikWejsciowy pw = new PlikWejsciowy();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(pw.path);
           Console.WriteLine("SPRAWDZENIE KLASYpw.content");
            Console.WriteLine(pw.content);


            Console.WriteLine("SPRAWDZENIE KLASY nie działająca ścieżka ");
            try
            {
                PlikWejsciowy w = new PlikWejsciowy("aaaaaaaaaaaa");
            } catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("nie mozńa utworzyc pliku");
            }


            Console.WriteLine("SPRAWDZENIE KLASY  działająca ścieżka ");
            Console.WriteLine( );
            try
            {
                PlikWejsciowy we= new PlikWejsciowy(curFile);

                //   Console.WriteLine(we.path);
                //    Console.WriteLine(we.content);
                we.showContent();
                List<string> lista = we.getContent();
                Console.WriteLine("SPRAWDZENIE  metody GET");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                foreach (string s in lista)
                {
                    Console.WriteLine(s);
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("nie mozńa utworzyc pliku");
            }


          




        }






    }

    }








        
      



       



