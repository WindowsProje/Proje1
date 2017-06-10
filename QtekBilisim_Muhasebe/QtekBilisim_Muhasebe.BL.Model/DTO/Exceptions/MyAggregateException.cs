using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class MyAggregateException:ApplicationException
    {
        public MyAggregateException()
        {

        }
        public MyAggregateException(string message) :base(message)
        {

        }
        public MyAggregateException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "Aggregate Exception";
            }
        }
    }
}
