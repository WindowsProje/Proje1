using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class MyDirectoryNotFoundException:ApplicationException
    {
        public MyDirectoryNotFoundException()
        {

        }
        public MyDirectoryNotFoundException(string message) :base(message)
        {

        }
        public MyDirectoryNotFoundException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "Directory Not Found Exception";
            }
        }
    }
}
