using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class MyFormatException:ApplicationException
    {
        public MyFormatException()
        {

        }
        public MyFormatException(string message) :base(message)
        {

        }
        public MyFormatException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "Format Exception";
            }
        }
    }
}
