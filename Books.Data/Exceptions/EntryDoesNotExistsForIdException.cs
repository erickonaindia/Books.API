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
    public class EntryDoesNotExistsForIdException : ApplicationException
    {
        public EntryDoesNotExistsForIdException() : base(Resources.Strings.ENTRY_DOES_NOT_EXIST)
        {

        }

        protected EntryDoesNotExistsForIdException(SerializationInfo info, StreamingContext context) : base(Resources.Strings.ENTRY_DOES_NOT_EXIST)
        {

        }
    }
}
