﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancario
{
    public interface ILog
    {

        //1º Fase.
        bool write(string msg);
    }
}
