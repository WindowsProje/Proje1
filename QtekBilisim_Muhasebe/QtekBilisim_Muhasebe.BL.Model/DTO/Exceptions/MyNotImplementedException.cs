using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class MyNotImplementedException:ApplicationException
    {
        public MyNotImplementedException()
        {

        }
        public MyNotImplementedException(string message) :base(message)
        {

        }
        public MyNotImplementedException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "Not Implemented Exception";
            }
        }
    }
}
