using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Cwiczenie2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Xml;
    using System.Xml.Linq;
    public class PlikWyjsciowy
    {

        List<string> listaDanych;

        public PlikWyjsciowy(List<string> listaDanych)
        {

            this.listaDanych = listaDanych;
            UtorzeniePlikuXML();



        }


        public void UtorzeniePlikuXML()
        {

            XElement cust = new XElement("studenci",


          from str in listaDanych
          let fields = str.Split(',')

          select new XElement("Student",
              new XAttribute("indexNumber", fields[0]),
              new XElement("fname", fields[1]),
              new XElement("lname", fields[2]),
              new XElement("birthdate", fields[3]),
              new XElement("Phone", fields[4]),
              new XElement("mothersname", fields[5]),
               new XElement("fathersname", fields[6]),
              new XElement("studies",
                  new XElement("name", fields[7]),
                  new XElement("mode", fields[8])


              )
          )
          );



            Console.WriteLine(cust);
            var studentXml = new XDocument();



            DateTime dt = DateTime.Now;
            string czas = dt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR"));


            //Now, we are Adding the Root Element  
            var rootElement = new XElement("uczelnia",
                new XAttribute("createdAt", czas),
                new XAttribute("author", "Weronika Jaworek")
             );

            studentXml.Add(rootElement); 

            var e2 = new XElement(cust);


            rootElement.Add(cust);
          
 //         Console.WriteLine(studentXml.ToString());
            studentXml.Save("myData.xml");
  //        Console.ReadKey();









        }








    }
}
