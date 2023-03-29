using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Books.Data.Exceptions
{
    [Serializable]
    public class InvalidModifiedOnUTCFieldException : ApplicationException
    {
        public InvalidModifiedOnUTCFieldException() : base(Resources.Strings.INVALID_MODIFIED_ON_UTC_MESSAGE)
        {

        }

        protected InvalidModifiedOnUTCFieldException(SerializationInfo info, StreamingContext context) : base(Resources.Strings.INVALID_MODIFIED_ON_UTC_MESSAGE)
        {

        }
    }
}
