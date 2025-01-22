using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactored.Interfaces
{
    public interface IDatabase
    {
        void Save(string input, string timestamp);

        string Retrieve(int index);
    }
}
