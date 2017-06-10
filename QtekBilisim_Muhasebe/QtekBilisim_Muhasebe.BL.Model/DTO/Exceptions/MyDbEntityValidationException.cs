using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class MyDbEntityValidationException:ApplicationException
    {
        public MyDbEntityValidationException()
        {

        }
        public MyDbEntityValidationException(string message) :base(message)
        {

        }
        public MyDbEntityValidationException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "Db Entity Validation Exception";
            }
        }
    }
}
