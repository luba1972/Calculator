﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Helpers
{
    public interface IContainerHelper
    {
        object  Create(string typeName);
    }
}
