﻿using System;
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
                DaneStudentow ds = new DaneStudentow(pw.content);
                ListaStudentow ls = new ListaStudentow(ds.zestawDanychStudentow);
                List<Student> list = ls.listaStudentow;
            List<string> lista = ls.listaStudent;
            PlikWyjsciowy pwyj = new PlikWyjsciowy(lista);


   /*       string[] s = {
               "Agnieszka","Brzęczyszczykiewicz382","Informatyka dzienne po angielsku","Dzienne",
                "4603","2000-02-12","382@pjwstk.edu.pl","lina", "Adam"
            };



            Student details = new Student(s);
         // Serialize(details);


            // Create the text file.
            string csvString = @"GREAL,Great Lakes Food Market,Howard Snyder,Marketing Manager,(503) 555-7555,2732 Baker Blvd.,Eugene,OR,97403,USA
HUNGC,Hungry Coyote Import Store,Yoshi Latimer,Sales Representative,(503) 555-6874,City Center Plaza 516 Main St.,Elgin,OR,97827,USA
LAZYK,Lazy K Kountry Store,John Steel,Marketing Manager,(509) 555-7969,12 Orchestra Terrace,Walla Walla,WA,99362,USA
LETSS,Let's Stop N Shop,Jaime Yorres,Owner,(415) 555-5938,87 Polk St. Suite 5,San Francisco,CA,94117,USA";
           
            File.WriteAllText("cust.csv", csvString);


         DateTime thisDay = DateTime.Today;
            // Display the date in the default (general) format.
            string data = thisDay.ToString();



            XElement cust = new XElement("studenci",
        
               
          from str in lista
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


































       /*   XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            settings.NewLineOnAttributes = true;

            var writer = XmlWriter.Create(Console.Out, settings);

            writer.WriteStartElement("uczelnia");
            writer.WriteAttributeString("orderID", "367A54");
            writer.WriteAttributeString("date", "2001-05-03");
            
            writer.WriteEndElement();
            writer.Flush();

*/






            /*     // Read into an array of strings.
        //         string[] source = File.ReadAllLines("cust.csv");
                   XElement cust = new XElement("uczelnie",
                    new XAttribute("createdAt", data),
                    new XAttribute("author", "Weronika Jaworek"), 

                   from str in pw.content
                   let fields = str.Split(',')
                   select new XElement("Customer",
                       new XAttribute("CustomerID", fields[0]),
                       new XElement("CompanyName", fields[1]),
                       new XElement("ContactName", fields[2]),
                       new XElement("ContactTitle", fields[3]),
                       new XElement("Phone", fields[4]),
                       new XElement("FullAddress",
                           new XElement("Address", fields[5]),
                           new XElement("City", fields[6]),
                           new XElement("Region", fields[7]),
                           new XElement("PostalCode", fields[8])

                       )
                   )
                   ); */
            //    Console.WriteLine(cust);



            /*
                        XmlRootAttribute oRootAttr = new XmlRootAttribute();
                        oRootAttr.ElementName = "Persons";
                        oRootAttr.IsNullable = true;
                        XmlSerializer oSerializer = new XmlSerializer(typeof(List<Student>), oRootAttr);
                        StreamWriter oStreamWriter = null;
                        try
                        {
                            oStreamWriter = new StreamWriter("person.xml");
                            oSerializer.Serialize(oStreamWriter, list);
                        }
                        catch (Exception oException)
                        {
                            Console.WriteLine("Aplikacja wygenerowała następujący wyjątek: " + oException.Message);
                        }
                        finally
                        {
                            if (null != oStreamWriter)
                            {
                                oStreamWriter.Dispose();
                            }
                        }


                        */
     /*     var studentXml = new XDocument();




           

            DateTime dt = DateTime.Now;
            string czas = dt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR"));


            //Now, we are Adding the Root Element  
            var rootElement = new XElement("uczelnia",
                new XAttribute("createdAt", czas),
           new XAttribute("author", "Weronika Jaworek"));
            studentXml.Add(rootElement); //done with it  
                                         // Now we will add the child Element  
           

            var e2 = new XElement(cust);


            rootElement.Add(cust);
         /* foreach (Student temp in list) 
            {
                // Create Child Element  
                var s1= new XElement("Student");


                //Now, add their child Element  
                var nameElement = new XElement("Name", temp.lname);
                s1.Add(nameElement);
                //Again, add Location in the same way  
                var locationElement = new XElement("Location", temp.fname);
                s1.Add(locationElement);
                // add the Main Child element to root  


                rootElement.Add(s1   );
            }

*/  /*      // Now, we will read the Created File  
            Console.WriteLine(studentXml.ToString());
            studentXml.Save("myData.xml");
            Console.ReadKey();


            Console.Write("aaaaa"); */

        }










    }



























   
          








































    }
    









































        
      



       



