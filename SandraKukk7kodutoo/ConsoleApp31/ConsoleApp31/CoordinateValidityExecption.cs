using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class CoordinateValidityExecption : Exception
    {
        public CoordinateValidityExecption(string message): base(message){}
    }
}
