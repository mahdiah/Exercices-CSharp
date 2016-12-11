using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace DAL
{
    public class GetData
    {
        //public static string chaine = null;
        
        public static string LoadLanguages()
        {
           

            WebRequest wReq = WebRequest.Create("http://publications.europa.eu/mdr/resource/authority/timeperiod/xml/timeperiods.xml");
           // WebRequest wReq = WebRequest.Create("http://publications.europa.eu/mdr/resource/authority/human-sex/xml/humansexes.xml");
            //WebRequest wReq = WebRequest.Create("http://publications.europa.eu/mdr/resource/authority/language/xml/languages.xml");
            // http://publications.europa.eu/mdr/resource/authority/place/xml/places.xml 
            // "http://publications.europa.eu/mdr/resource/authority/human-sex/xml/humansexes.xml"
            // "http://publications.europa.eu/mdr/resource/authority/atu-type/xml/atu-type.xml"
            // http://publications.europa.eu/mdr/resource/authority/timeperiod/xml/timeperiods.xml 
            // http://publications.europa.eu/mdr/resource/authority/currency/xml/currencies.xml 
            // http://publications.europa.eu/mdr/resource/authority/continent/xml/continents.xml 
            // http://publications.europa.eu/mdr/resource/authority/country/xml/countries.xml 
            // http://publications.europa.eu/mdr/resource/authority/address-type/xml/addresstypes.xml 
            // http://publications.europa.eu/mdr/resource/authority/address-type/xml/addresstypes.xml 
           // wReq.ContentType = "application/xml";
            //wReq.Accept = "application/xml";
            try
            {
                WebResponse wResp = wReq.GetResponse();
                using (StreamReader sr = new StreamReader(wResp.GetResponseStream(), Encoding.UTF8))
                {
                    int length = 512;
                    char[] Buffer = new char[512];
                    int bytesread = 0;
                    //Read from the stream 
                    bytesread = sr.Read(Buffer, 0, length);
                    StringBuilder sb = new StringBuilder();

                    // Essaie de lire en une seule fois le flux sr
                    //sb.Append(sr.ReadToEnd());

                    while (bytesread > 0)
                    {
                        
                        sb.Append(Buffer, 0, length);
                        bytesread = sr.Read(Buffer, 0, length);
                    }
                     
                    return sb.ToString();
                }

            }
            catch (WebException e)
            {

                throw new WebException("problème serveur : " + e.Message);
            }

        }


        public static string GetListe()
        {

            List<Timeperiods> liste = new List<Timeperiods>();

            string pattern = "<record(.*)</record>";
            string input = GetData.LoadLanguages();

           Match m = Regex.Match(input, pattern,RegexOptions.Singleline);
            return m.Groups[1].Value;
            //while (m.Success)
            //{
            //    Timeperiods tp = getTimePeriods(m.Groups[1].Value);
            //    liste.Add(tp);
            //    m = m.NextMatch();
            //}

            //string patternAC = @"<authority-code>(.*)<";
            //string patternLg = "<lg.version lg=\"eng\">(.*)<";
            //string patternPQ = @"<period.qualifier>(.*)<";



            //return liste;
        }


        //private static Timeperiods getTimePeriods(string input)
        //{
        //    return new Timeperiods()
        //}
    }
}
