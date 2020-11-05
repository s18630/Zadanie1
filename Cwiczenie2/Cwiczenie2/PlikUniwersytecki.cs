using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Cwiczenie2
{
    public enum FormatDanych
    {
     xml,
     json 
    };

    class PlikUniwersytecki
       
    {
        string AdresPlikuCSV = "data.csv";
        string adresScieżkiDocelowej = "żesult.xml" ;
        FormatDanych formatDanych = FormatDanych.xml;
        


        PlikUniwersytecki(string[]arg)
        {
            

        }


       public static string getAdresPlikuCSV (string adresPlikuCSV)
        {
            return "wartosc";
        }


    }



}
