using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;
using TestRabnot.Model;

namespace TestRabnot.Service
{
    internal class AllFunction
    {
        private static readonly string _path = Path.Combine(
           Directory.GetCurrentDirectory(),
           "Days.xml"
       );
        public static XDocument ReadDocument() => XDocument.Load(_path);
        public static void CreateXmlIfNotExist()
        {
            if (!File.Exists(_path))
            {
                XDocument document = XDocument.Parse(@"<queries></queries>");
                document.Save(_path);
            }
        }
        public static XElement ConvertQueryToXElement(QueryModel query) =>
            new("Query",
                new XElement("Day", query.Day),
                new XElement("DayInMonth", query.DayInMonth),
                new XElement("Month", query.Month),
                new XElement("Year", query.Year),
                new XElement("res", query.Res)

            );
        
        public static void Addquery(XDocument document, QueryModel query)
        {

            document.Descendants("queries")
                .First()
                .Add(ConvertQueryToXElement(query));
            document.Save(_path);

        }
      
    
    }
}
