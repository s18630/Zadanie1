using System;
using System.Collections.Generic;
using System.Text;

namespace Cwiczenie2
{
  public class Student
    {

        public string indexNumber;
        public string fname;
        public string lname;
        public string birthdate;
        public string email;
        public string mothersName;
        public string fathersName;
        public string studiesName;
        public string studiesMode;
        public int countData;


        public Student( string [] args)
        {
            if (args == null)
            {
                throw new Exception(" Nie dostarczono elementów");
            }
            countData = 9;
           
            if( args.Length!=countData)
            {
                throw new Exception(" Nie ma 9 elementów do metody ");
            }else
            {
                this.indexNumber = args[0];
                this.fname = args[1];
                this.lname = args[2];
                this.birthdate= args[3];
                this.email= args[4];
                this.mothersName= args[5];
                this.fathersName= args[6];
                this.studiesName= args[7];
                this.studiesMode = args[8];
                //oprogramwoac jeszcze jak jakas jest pusta wartosc
            }
            

        }
        public Student( ZestawDanych zestaw)
        {

            string[] args = zestaw.getZestawDanych();

            this.indexNumber = args[4];
            this.fname = args[0];
            this.lname = args[1];
            this.birthdate = args[5];
            this.email = args[6];
            this.mothersName = args[7];
            this.fathersName = args[8];
            this.studiesName = args[2];
            this.studiesMode = args[3];

            countData = args.Length;


        }

    }
}
