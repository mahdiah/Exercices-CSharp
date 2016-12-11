using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Model
{
    public class Timeperiod : Nal_Base
    {
        public string Name;

        public Timeperiod(string pRecordXml) : base(pRecordXml)
        {
            string labelXml = getAttribute(pRecordXml, "<label>", "</label>");
            this.Name = getAttribute(labelXml, "<lg.version lg=\"fra", "</lg.version>");

        }

        public Timeperiod(XmlNode pRecordNode):base(pRecordNode)
        {
            XmlNodeList childNodes = pRecordNode.SelectNodes("label/lg.version[@lg='fra'] | name/alternative.name/lg.version[@lg='fra']");

            foreach (XmlNode item in childNodes)
            {
                


                this.Name += item.InnerText+ " ";


            }

            //this.Name = pNode.SelectSingleNode("lg.version[@lg='fra']").InnerText;


        }
    }
}
