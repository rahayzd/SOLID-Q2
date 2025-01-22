using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refactored.Model;

namespace Refactored.Interfaces
{
    public interface IZookeeperManager
    {
        void ProcessSalaries(IEnumerable<Zookeeper> zookeepers);
    }
}
