﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyLocate
{
    internal sealed class MacFactory : IFactory
    {
      
        public IButton MakeButton()
        {
            return new MacButton();
        }

    
    }
}
