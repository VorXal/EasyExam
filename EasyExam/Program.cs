using System;
using System.Xml.Linq;

namespace EasyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter PATH: ");
            string fileName = Console.ReadLine();
            XDocument doc = XDocument.Load(fileName);
            Console.Write("Number?");
            int choice = Convert.ToInt32(Console.ReadLine());
            foreach(XElement el in doc.Element("tickets").Elements("ticket"))
            {
                int id = (int)el.Attribute("id");
                if(id == choice)
                {
                    Console.WriteLine(el.Element("answer").Value);
                }
            }
            Console.ReadKey();
        }
    }
}
