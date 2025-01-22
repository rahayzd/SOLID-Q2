using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refactored.Interfaces;

namespace Refactored.Model
{
    public class ZookeeperManager : IZookeeperManager
    {
        private readonly IDatabase _database;
        private readonly ISalaryCalculator _salaryCalculator;

        public ZookeeperManager(IDatabase database, ISalaryCalculator salaryCalculator)
        {
            _database = database;
            _salaryCalculator = salaryCalculator;
        }

        public void ProcessSalaries(IEnumerable<Zookeeper> zookeepers)
        {
            foreach (var zookeeper in zookeepers)
            {
                var salary = _salaryCalculator.CalculateSalary(zookeeper.Id);
                _database.Save(salary, "Salary paid");
            }
        }
    }

}
