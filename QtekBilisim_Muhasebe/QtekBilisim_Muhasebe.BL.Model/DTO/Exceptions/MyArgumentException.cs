using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class MyArgumentException:ApplicationException
    {
        public MyArgumentException()
        {

        }
        public MyArgumentException(string message) :base(message)
        {

        }
        public MyArgumentException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "Argument Exception";
            }
        }
    }
}
