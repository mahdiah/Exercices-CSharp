namespace Model
{
    public class Language : Nal_Base
    {
        public string OriginalName;

        public Language(string pRecord):base(pRecord)
        {
            this.OriginalName = getAttribute(pRecord, "<lg.version lg=", "</lg.version>");
        }

    }
}