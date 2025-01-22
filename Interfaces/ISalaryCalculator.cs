using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactored.Interfaces
{
    public interface ISalaryCalculator
    {
        string CalculateSalary(long userId);
    }

    public class SalaryCalculator : ISalaryCalculator
    {
        public string CalculateSalary(long userId)
        {
            return (userId * 1100 - userId).ToString();
        }
    }
}
