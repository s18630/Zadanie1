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
            List<string> lista = pw.getFalseContent();
     DaneStudentow ds = new DaneStudentow(lista);
      //    ListaStudentow ls = new ListaStudentow(ds.zestawDanychStudentow);
      //    List<Student>list = ls.listaStudentow;


        }
















    }
    }








        
      



       



