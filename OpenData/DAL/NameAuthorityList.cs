using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NameAuthorityList
    {
        public string LoadXmlData(NAL pNal)
        {
            string url = "http://publications.europa.eu/mdr/resource/authority/";
            switch (pNal)
            {
                
                case NAL.Countries:
                    url += "country/xml/countries.xml";
                    break;
                case NAL.Languages:
                    url += "language/xml/languages.xml";
                    break;
                case NAL.Honorifics:
                    url += "honorific/xml/honorifics.xml";
                    break;
                case NAL.Places:
                    url += "place/xml/places.xml";
                    break;
                case NAL.Sexes:
                    url += "human-sex/xml/humansexes.xml";
                    break;
                case NAL.ATU_Types:
                    url += " atu-type/xml/atu-type.xml";
                    break;
                case NAL.TimePeriods:
                    url += "timeperiod/xml/timeperiods.xml";
                    break;
                case NAL.Currencies:
                    url += "currency/xml/currencies.xml";
                    break;
                case NAL.Continents:
                    url += "continent/xml/continents.xml";
                    break;
                case NAL.AdressTypes:
                    url += "address-type/xml/addresstypes.xml";
                    break;
                case NAL.ATU:
                    url += "atu/xml/atu.xml";
                    break;
                default:
                    break;
            }

            WebRequest wReq = WebRequest.Create(url); ;
            WebResponse wResp = wReq.GetResponse();
            // Get a readable stream from the server
            using (StreamReader sr = new StreamReader(wResp.GetResponseStream(), Encoding.UTF8))
            {
                int length = 512;
                char[] Buffer = new char[length];
                int bytesread = 0;
                //Read from the stream and write data to console
                StringBuilder mySB = new StringBuilder();
                bytesread = sr.Read(Buffer, 0, length);
                while (bytesread > 0)
                {
                    mySB.Append(Buffer, 0, bytesread);
                    bytesread = sr.Read(Buffer, 0, length);
                }
                return mySB.ToString();
            }
           
        } 
    }
}
