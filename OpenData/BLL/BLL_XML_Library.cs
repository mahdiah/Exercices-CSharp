using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BLL
{
    public class BLL_XML_Library
    {
        public List<Timeperiod> FillList(NAL pNal)
        {
            //NameAuthorityList myData = new NameAuthorityList();
            //string storedString = (myData.LoadXmlData(NAL.Countries));
            List<Timeperiod> myTimePeriods = new List<Timeperiod>();
            XmlDocument doc = new XmlDocument();
            //load à partir d'un string
            //doc.Load(storedString);

            //load à partir d'une URL
            string url = "http://publications.europa.eu/mdr/resource/authority/";
            url += "timeperiod/xml/timeperiods.xml";
            doc.Load(url);

           // XmlNode node = doc.DocumentElement.SelectSingleNode("record");
           // string timeperiodID = node.Attributes["id"].InnerText;

            foreach (XmlNode recordNode in doc.DocumentElement.ChildNodes)
            {
                Timeperiod mytp = new Timeperiod(recordNode);
                myTimePeriods.Add(mytp);
            }


            return myTimePeriods;
        }
    }
}
