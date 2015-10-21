using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAddInNHibernate
{
    public class ThisAddinException : Exception
    {
        public const string DATA_MANAGER_UNAVAILABLE = "Data Manager unavailable";

        public ThisAddinException( string errorMessage )
            : base( errorMessage )
        { }
    }
}
