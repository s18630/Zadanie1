using System;
using System.Collections.Generic;
using System.Text;

namespace Cwiczenie2
{
    class DaneStudentow : FindData<ZestawDanych>
    {
        public List<ZestawDanych> ZestawDanychStudentow;
      

        public DaneStudentow(List<string> lista)
        {
            ZestawDanychStudentow = new List<ZestawDanych>();
            //this.dataSet = dataSet;

            ZestawDanychStudentow = findData(lista);
        }

        public List<ZestawDanych> findData(List<string> lista)
        {


            Console.WriteLine(" ROZPOCZELA SIE METODA dind DAta");
            //    throw new NotImplementedException();
            foreach( string s in lista)
            {
                Console.WriteLine(" w pentli ");


                string[] studentsData= s.Split(',');
                Console.WriteLine(" poczatek ---------");
                foreach ( string k in studentsData)
                {
                    Console.WriteLine(k);
                    Console.WriteLine();
                }

                Console.WriteLine(" poczatek ---------");


                if (studentsData.Length!= 9)
                {
                    Console.WriteLine(" zła ilość danych ");
                }
                else
                {
                    ZestawDanychStudentow.Add(new ZestawDanych(studentsData));
                }





            }


            return ZestawDanychStudentow;


        }
    }
}
