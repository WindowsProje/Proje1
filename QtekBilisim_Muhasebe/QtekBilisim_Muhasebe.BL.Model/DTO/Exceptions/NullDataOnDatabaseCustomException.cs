using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class NullDataOnDatabaseCustomException:ApplicationException
    {
        public NullDataOnDatabaseCustomException()
        {

        }
        public NullDataOnDatabaseCustomException(string message) :base(message)
        {

        }
        public NullDataOnDatabaseCustomException(string message, Exception error):base(message, error)
        {

        }
    }
}
