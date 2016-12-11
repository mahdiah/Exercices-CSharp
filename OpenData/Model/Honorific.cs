namespace Model
{
    public class Honorific : Nal_Base
    {
        //public string ISO;
        public string Name;
        public string LongName;


        public Honorific(string pRecord):base(pRecord)
        {
           
            string labelXml = getAttribute(pRecord, "<label>", "</label>");
            this.Name = getAttribute(labelXml, "<lg.version lg=\"fra", "</lg.version>");
            string longLabelXml = getAttribute(pRecord, "<long.label>", "</long.label>");
            this.LongName = getAttribute(longLabelXml, "<lg.version lg=\"fra", "</lg.version>");
        }
    }
}