using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class MyArgumentNullException:ApplicationException
    {
        public MyArgumentNullException()
        {

        }
        public MyArgumentNullException(string message) :base(message)
        {

        }
        public MyArgumentNullException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "Argument Null Exception";
            }
        }
    }
}
