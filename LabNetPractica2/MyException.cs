using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    internal class MyException : Exception
    {
        public MyException()
        {

        }
        public MyException(string message) : base(message)
        {

        }
        public override string Message => "Soy un mensaje personalizado " + base.Message;

    }
}
