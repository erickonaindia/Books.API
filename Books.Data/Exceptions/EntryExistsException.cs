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
    public class EntryExistsException : ApplicationException
    {
        public EntryExistsException() : base(Resources.Strings.ENTRY_ALREADY_EXISTS_MESSAGE)
        {

        }

        public EntryExistsException(string message) : base(message)
        {

        }

        protected EntryExistsException(SerializationInfo info, StreamingContext context) : base(Resources.Strings.ENTRY_ALREADY_EXISTS_MESSAGE)
        {

        }
    }
}
