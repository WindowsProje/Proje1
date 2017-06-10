using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class MyFileNotFoundException:ApplicationException
    {
        public MyFileNotFoundException()
        {

        }
        public MyFileNotFoundException(string message) :base(message)
        {

        }
        public MyFileNotFoundException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "File Not Found Exception";
            }
        }
    }
}
