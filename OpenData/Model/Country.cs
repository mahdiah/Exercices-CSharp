namespace Model
{
    public  class Country : Nal_Base 
    {
        public string ISO;
        public string Name;
        public string LongName;
        public string Continent;
        public string DateOfEvent;

        public Country(string pRecordXml) : base(pRecordXml)
        {

            string labelXml = getAttribute(pRecordXml, "<label>", "</label>");
            this.Name = getAttribute(labelXml, "<lg.version lg=\"fra", "</lg.version>");
            this.ISO = getAttribute(pRecordXml, "<code-3166-1-alpha-3>", "</code-3166-1-alpha-3>");
            string longLabelXml = getAttribute(pRecordXml, "<long.label>", "</long.label>");
            this.LongName = getAttribute(longLabelXml, "<lg.version lg=\"fra", "</lg.version>");

        }

      
    }
}