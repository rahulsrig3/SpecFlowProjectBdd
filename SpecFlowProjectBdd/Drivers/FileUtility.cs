using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectBdd.Drivers
{
    public class FileUtility
    {
        public string ReadDataFromRunsettings(string key)
        {
            string value = TestContext.Parameters.Get(key);
            return value;
        }
    }
}
