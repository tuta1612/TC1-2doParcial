﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Domain
{
    public class Log
    {
        public String message { get; set; }

        public EnumSeverity severity { get; set; }

    }

    public enum EnumSeverity { DEBUG, INFO, WARNING, ERROR }
}
