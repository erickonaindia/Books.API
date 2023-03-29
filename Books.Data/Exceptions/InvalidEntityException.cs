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
    public class InvalidEntityException : ApplicationException
    {
        public InvalidEntityException() : base(Resources.Strings.INVALID_ENTITY_MESSAGE)
        {

        }

        protected InvalidEntityException(SerializationInfo info, StreamingContext context) : base(Resources.Strings.INVALID_ENTITY_MESSAGE)
        {

        }
    }
}
