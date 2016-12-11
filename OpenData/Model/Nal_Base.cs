using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Model
{
    public  class Nal_Base
    {
        public string ID;

        public string Code;

        public Nal_Base(string pRecordXml)
        {
            this.ID = getAttribute(pRecordXml, "id=\"", "\"");
            this.Code = getAttribute(pRecordXml, "<authority-code>", "</authority-code>");
        }

        public Nal_Base(XmlNode pNode)
        {
            this.ID = pNode.Attributes["id"].InnerText;
            this.Code = pNode.FirstChild.InnerText;
        }

        protected string getAttribute(string pRecordString, string pSearchedStringStart, string pSearchedStringEnd)
        {
            string attribute = "/";
            int startIndex = pRecordString.IndexOf(pSearchedStringStart, 0) + pSearchedStringStart.Length;
            int endIndex = pRecordString.IndexOf(pSearchedStringEnd, startIndex);
            if (startIndex > 0 && endIndex > 0)
            {
                attribute = pRecordString.Substring(startIndex, endIndex - startIndex);
                string cutUselessPart = ">";
                startIndex = attribute.IndexOf(cutUselessPart, 0);
                if (startIndex >= 0)
                {
                    attribute = attribute.Substring(startIndex + cutUselessPart.Length);
                }
            }
            return attribute;
        }
    }
}