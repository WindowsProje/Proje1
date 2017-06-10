using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class MyPathTooLongException:ApplicationException
    {
        public MyPathTooLongException()
        {

        }
        public MyPathTooLongException(string message) :base(message)
        {

        }
        public MyPathTooLongException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "Path Too Long Exception";
            }
        }
    }
}
