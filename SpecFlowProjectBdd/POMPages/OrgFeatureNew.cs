using OpenQA.Selenium;
using SpecFlowProjectBdd.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectBdd.POMPages
{
    public class OrgFeatureNew
    {
        IWebDriver driver = null;
        public OrgFeatureNew(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}
