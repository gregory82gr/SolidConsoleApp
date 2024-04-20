using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepedencyInversionPrincipleSolution
{
    public interface IEmployeeDataAccessLogic
    {
        Employee GetEmployeeDetails(int id);
    }
}
