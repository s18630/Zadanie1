using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Cwiczenie2
{
    class DaneStudentow   
    //  : FindData<ZestawDanych>
    {
        public List<ZestawDanych> zestawDanychStudentow;
      

        public DaneStudentow(List<string> lista)
        {
            zestawDanychStudentow = new List<ZestawDanych>();
            
     extractData(lista);
         
        }

        public void     extractData(List<string> lista)
        {
            int iloscposprawdzeniu = 0;

            int iloscrekordowWejsciowych = lista.Count;
            Console.WriteLine(" ROZPOCZELA SIE METODA dind DAta");
            //    throw new NotImplementedException();
            foreach (string s in lista)
            {
                Console.WriteLine(" w pentli ");


                string[] studentsData = s.Split(',');


                Console.WriteLine(" zła ilość danych?");


                try
                {
                   
                    zestawDanychStudentow.Add(new ZestawDanych(studentsData));

                    foreach (string k in studentsData)
                    {
                        Console.WriteLine(k);
                        Console.WriteLine();
                    }

                    Console.WriteLine(" koniec   ---------");

                    iloscposprawdzeniu++;

                }
                catch (Exception ex)
                {

                    Console.WriteLine(" WYSTAPIL BLAD     ");
                    Console.WriteLine(ex.Message);




                }




                




            }




            // zrobić set data i dodać 

          

Console.WriteLine(" przed " + iloscrekordowWejsciowych + "----> " + "po" + iloscposprawdzeniu);

             


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

        public void setZestawyDanych(List<ZestawDanych> zestawyDanych)
        {
            this.zestawDanychStudentow=zestawyDanych;
        }

        public List <ZestawDanych> GetZestawDanyches()
        {
            return zestawDanychStudentow;
        }




    }
}
