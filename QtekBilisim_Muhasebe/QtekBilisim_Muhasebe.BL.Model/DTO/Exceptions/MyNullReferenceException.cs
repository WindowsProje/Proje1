﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions
{
    public class MyNullReferenceException:ApplicationException
    {
        public MyNullReferenceException()
        {

        }
        public MyNullReferenceException(string message) :base(message)
        {

        }
        public MyNullReferenceException(string message, Exception error):base(message, error)
        {

        }
        public override string Message
        {
            get
            {
                return "Null Reference Exception";
            }
        }
    }
}