using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class BLL_Construct<T> where T: Nal_Base  // test de garde pour ne pas instancier n'importe quoi
    {
       
        public string DisplayData(NAL pNal)
        {
            NameAuthorityList myData = new NameAuthorityList();
            string storedString = myData.LoadXmlData(pNal);
            return storedString;
        }
    

        protected Caption getRecord(string pXmlString, string pSearchedStringStart, string pSearchedStringEnd, int pPreviousLastIndex)
        {
            
            int checkIfInSequence = pXmlString.IndexOf(pSearchedStringStart, pPreviousLastIndex);
            Caption newCaption = new Caption();
            newCaption.inSequence = checkIfInSequence > 0;
            if (newCaption.inSequence)
            {
                int startIndex = pXmlString.IndexOf(pSearchedStringStart, pPreviousLastIndex) + pSearchedStringStart.Length;
                int endIndex = pXmlString.IndexOf(pSearchedStringEnd, startIndex);
                newCaption.sequence = pXmlString.Substring(startIndex, endIndex - startIndex);
                newCaption.index = endIndex;
            }
            
            return newCaption;
        }


        public List<T> FillList(NAL pNal)
        {
            NameAuthorityList myData = new NameAuthorityList();
            string storedString = (myData.LoadXmlData(pNal));
            List<T> myList = new List<T>();
            int startIndex = 0;
            bool inSequence = true;
            while (inSequence == true)
            {

                Caption myCaption = getRecord(storedString, "<record ", "</record>", startIndex);
                int a = storedString.Length;
                if (myCaption.inSequence == true)
                {
                    T myT = (T) Activator.CreateInstance(typeof(T),myCaption.sequence);
                    myList.Add(myT);
                    startIndex = myCaption.index;
                }
                inSequence = myCaption.inSequence;
            }
            return myList;
        }


        protected class Caption
        {
            internal int index;
            internal string sequence;
            internal bool inSequence;
        }
    }
}