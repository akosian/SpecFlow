using Frame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class TestConfiguration
    {

        [AssemblyInitialize]
        public void SetUp()
        {
            new Browser().GetDriver();
        }

        [AssemblyCleanup]
        public void Finish()
        {
            new Browser().GetDriver().Close();
        }
    }
}
