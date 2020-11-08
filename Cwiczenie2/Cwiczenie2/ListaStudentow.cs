using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Xml.Serialization;

namespace Cwiczenie2
{
   
    public class ListaStudentow
    {     
        public List<Student> listaStudentow;
        SpisBledow spis;




        public ListaStudentow(List <ZestawDanych> zestawDanych)
        {

            listaStudentow = new List<Student>();
            spis = new SpisBledow();
            addNewStudents(zestawDanych);

        }


        public ListaStudentow(DaneStudentow dane)
        {

            listaStudentow = new List<Student>();
            List<ZestawDanych> zestawDanych = dane.zestawDanychStudentow;
            spis = dane.spisBledow;
            addNewStudents(zestawDanych);


        }















        public void addNewStudents(List <ZestawDanych> zestawyDanych)
        {
            int iloscZestawow = zestawyDanych.Count;
            int iloscDodanychStudentow = 0;


             int liczaDuplikatow= 0;

           foreach(ZestawDanych zd in zestawyDanych)
            {


                try {

                    Student nowyStudeny = new Student(zd);

                    if (isDuplicate(nowyStudeny) == false)
                    {

                        Console.WriteLine(" nie jest duplikatem wiec go dodajemy  ");


                        listaStudentow.Add(nowyStudeny);
                        iloscDodanychStudentow++;

                    }
                    else
                    {
                        liczaDuplikatow++;
                        spis.zapiszDoPliku(" Wykryty duplikat nr " + liczaDuplikatow);

                        Console.WriteLine(" Zapis niemożliwy, to duplikat  ");
                        Console.WriteLine();
                    }


                }
                catch(Exception ex)
                {

                    spis.zapiszDoPliku(" Wystąpił bład :  " + ex.Message);

                    Console.WriteLine("Wystąpił bład :  " + ex.Message );
                    Console.WriteLine();




                }


                    
            }

            Console.WriteLine(" wczesniej bylo    " +  iloscZestawow  );
            Console.WriteLine(" zostało dodanych " + iloscDodanychStudentow);
            

        }











        public List<Student> getStudents()
        {
            return listaStudentow;
        }



        public void addStudent(Student student)
        {
            if (isDuplicate(student) == true)
            {
                Console.WriteLine(" Student już został wpisany do listy ");
                // oprogramowac blad
            }
            else
            {
                listaStudentow.Add(student);
                // sprawdź czy w liście nie ma takich samych studentów 
            }
        }








        public void showListaStudentow()
        {
            int i = 1;
            // sprawdź czy w liście nie ma takich samych studentów 
            foreach(Student s in listaStudentow)
            {
                Console.WriteLine("Student " + i + ":");
                i++;
                Console.WriteLine("index : " + s.indexNumber);
                Console.WriteLine("imie : " + s.fname);
                Console.WriteLine("nazwisko : " + s.lname);



            }
        }




        public bool isDuplicate(Student student)
        {
            foreach(Student s in listaStudentow)
            {
                int spelnioneWarunek = 0;

                if(Equals(s.indexNumber, student.indexNumber))
                {
                    spelnioneWarunek++;
                }

                if (Equals(s.fname, student.fname))
                {
                    spelnioneWarunek++;
                }

                if (Equals(s.lname, student.lname))
                {
                    spelnioneWarunek++;
                }

                if(spelnioneWarunek == 3)
                {
                    return true;
                }

            }
           

            return false;
        }




    }
}
