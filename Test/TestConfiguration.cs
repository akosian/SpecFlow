using Frame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class TestConfiguration
    {
        [TestInitialize]
        public void setUp()
        {
            new Browser().GetInstance();
        }


        [TestCleanup]
        public void close()
        {
            new Browser().GetInstance().Close();
        }
    }
}