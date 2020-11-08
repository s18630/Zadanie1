﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Cwiczenie2
{


    [Serializable]

    public class Student
    {
        [XmlAttribute("Id")]

        public string indexNumber { get; set; }
        [XmlElement(ElementName = "fname")]
        public string fname { get; set; }
        [XmlElement(ElementName = "lname")]
        public string lname { get; set; }
        [XmlElement(ElementName = "birthdate")]
        public string birthdate { get; set; }
        [XmlElement(ElementName = "email")]
        public string email { get; set; }
        [XmlElement(ElementName = "mothersName")]
        public string mothersName { get; set; }
        [XmlElement(ElementName = "fathersName")]
        public string fathersName { get; set; }
        [XmlElement(ElementName = "studiesName")]
        public string studiesName { get; set; }
        [XmlElement(ElementName = "studiesMode")]
        public string studiesMode { get; set; }
        public int countData { get; set; }


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
        public Student()
        {


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
