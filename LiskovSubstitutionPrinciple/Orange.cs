using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Orange:Apple
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
}
