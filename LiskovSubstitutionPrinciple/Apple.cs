﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
}
