using System;
using System.Collections.Generic;
using System.Text;

namespace Motor_Servicing.Test.Exceptions
{
    public class ServicesNotFoundException:Exception
    {
        public string Messages = " Services Not Found  ";

        public ServicesNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
