using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refactored.Interfaces;

namespace Refactored.Model
{
    public class MyDatabase : IDatabase
    {
        private ILogger _logger;
        public MyDatabase(ILogger logger) 
        {
            _logger = logger;

        }
        private readonly List<string> _data = new List<string>();

        public void Save(string input, string timestamp)
        {
            _data.Add(input + "|" + timestamp);
            _logger.Log("Data Saved: " + input + "|" + timestamp);
        }

        public string Retrieve(int index)
        {
            if (index < 0 || index >= _data.Count)
            {
                _logger.Log("No data");
                throw new Exception("No Data");
            }
            return _data[index];
        }


    }
}
