using System;
using System.Collections.Generic;
using System.Text;

namespace Sharedd
{
     public class NotFoundException : Exception
    {
        public NotFoundException(string message ) : base(message)
        {

        }
    }
}
