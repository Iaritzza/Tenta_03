using System;
using System.Collections.Generic;
using System.Text;

namespace ex_fix_tratamento_exece
{
    class DoMainException : ApplicationException
    {
        public DoMainException(string message) : base(message)
        {
        }
    }
}
