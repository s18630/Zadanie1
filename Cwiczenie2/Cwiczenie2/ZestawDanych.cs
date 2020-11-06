using System;
using System.Collections.Generic;
using System.Text;

namespace Cwiczenie2
{
 public class ZestawDanych
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

    
    public ZestawDanych(string [] args)
    {

            this.indexNumber = args[0];
            this.fname = args[1];
            this.lname = args[2];
            this.birthdate = args[3];
            this.email = args[4];
            this.mothersName = args[5];
            this.fathersName = args[6];
            this.studiesName = args[7];
            this.studiesMode = args[8];

        }


}

}
