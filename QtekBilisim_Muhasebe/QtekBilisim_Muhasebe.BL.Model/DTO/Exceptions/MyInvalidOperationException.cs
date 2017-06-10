using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class MyInvalidOperationException:ApplicationException
    {
        public MyInvalidOperationException()
        {

        }
        public MyInvalidOperationException(string message) :base(message)
        {

        }
        public MyInvalidOperationException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "Invalid Operation Exception";
            }
        }
    }
}
