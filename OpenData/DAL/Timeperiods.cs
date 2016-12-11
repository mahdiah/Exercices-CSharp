using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Timeperiods
    {
        string id;
        string authorityCode ;
        string lg;
        string periodQualifier ;

        public Timeperiods(string id, string authorityCode, string langue, string period)
        {
            this.id = id;
            this.authorityCode = authorityCode;
            this.lg = langue;
            this.periodQualifier = period;
        }
    }
}
