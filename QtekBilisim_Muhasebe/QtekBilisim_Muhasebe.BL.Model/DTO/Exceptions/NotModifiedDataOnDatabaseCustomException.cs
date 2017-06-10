using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class NotModifiedDataOnDatabaseCustomException:ApplicationException
    {
        public NotModifiedDataOnDatabaseCustomException()
        {

        }
        public NotModifiedDataOnDatabaseCustomException(string message) :base(message)
        {

        }
        public NotModifiedDataOnDatabaseCustomException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "Not Modified Data On Database Custom Exception";
            }
        }
    }
}
