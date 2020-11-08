using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Cwiczenie2
{
    [Serializable]

    public class ListaStudentow
    {

        public List<Student> listaStudentow;
   

        public ListaStudentow()
        {
            listaStudentow = new List<Student>();
        }

        public ListaStudentow(List <ZestawDanych> zestawDanych)
        {

            listaStudentow = new List<Student>();
            addNewStudents(zestawDanych);
        }



        public void addNewStudents(List <ZestawDanych> zestaw)
        {
            int iloscZestawow = zestaw.Count;
            int iloscDodanychStudentow = 0;

           foreach(ZestawDanych zd in zestaw)
            {
                Console.WriteLine(" próba stworzenia z zestawyu danych studenta");
                Student nowyStudeny = new Student(zd);

                if (isDuplicate(nowyStudeny) == false)
                {
                    Console.WriteLine(" nie jest duplikatem wiec go dodajemy  ");


                    listaStudentow.Add(nowyStudeny);
                    iloscDodanychStudentow++;
                }
                else
                {
                    Console.WriteLine(" TO DUPLIKAT :(                        ");
                    Console.WriteLine("    ");
                }
                    
            }

            Console.WriteLine(" wczesniej bylo    " +  iloscZestawow  );
            Console.WriteLine(" zostało dodanych " + iloscDodanychStudentow);
            Console.WriteLine(" wyswietl całaą listę                      ");

            showListaStudentow();


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
