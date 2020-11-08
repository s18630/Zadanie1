using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;


namespace Cwiczenie2
{
    public class PlikWejsciowy 
    {
        public string path;
        public List<string> content;
 

        public PlikWejsciowy(string path)
        {
           
            if (File.Exists(path))
            {
                this.path = path;
            }else
            {
                throw new Exception(" Scieżka nie istnieje");
            }

            content = new List<string>();

            readContent();

        }


        public PlikWejsciowy()
        {
            path = @"dane.csv";
         
            content = new List<string>();

             readContent();



        }

  
        private void readContent(){

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    content.Add(s);
                   
                }
            }



        }


        public void showContent()
        {

         foreach(string s in content)
         {
           Console.WriteLine(s);
         }

        }


        public List<string> getContent()
        {
            return content;
        }

        public List<string> getFalseContent()
        {

            List<string> falseContent = content;
            falseContent.Add("222, 3,2");
            falseContent.Add(", 3,2");

            return falseContent;
        }
    }



}




    

    
    


  


    

