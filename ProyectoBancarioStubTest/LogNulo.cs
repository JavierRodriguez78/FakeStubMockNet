using ProyectoBancario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancarioStubTest
{
    public class LogNulo : ILog
    {
       public bool write(string msg)
        {
            return false;
        }
       
    }
}
