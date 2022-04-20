using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectBdd.Drivers
{
    public class CSharpUtility
    {
        public int RandomNumber()
        {
            Random random = new Random();
            int randomNum = random.Next(1000);
            return randomNum;
        }

        public string GetSystemDateAndTime()
        {
            DateTime date = DateTime.Now;
            return date.ToString();
        }
    }
}
