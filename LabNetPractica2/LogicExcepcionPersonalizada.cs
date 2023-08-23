using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    internal class LogicExcepcionPersonalizada
    {
        public void GenerarExcepcion()
        {
            throw new MyException("Esta es mi excepcion");
        }
    }
}
