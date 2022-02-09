using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


using DominoProject;

namespace DominoProject.Tests
{
    [TestClass()]
    public class TestsSide
    {
        [TestMethod()]
        public void SideKonstruktor()
        {
            try
            {
                Side side = new Side("jobb oldal", 3);
            }
            catch (Exception e)
            {
                Assert.Fail("A pont konstruktor kivételt dob:" + e.Message);
            }
        }


        [TestMethod()]
        public void SideKonstruktorPont()
        {
            Side side = new Side("jobb oldal", 3);
            int expexted = 3;
            int actual=0;

            try
            {
                actual = side.Point;
            }
            catch (Exception e)
            {
                Assert.Fail("A pont get metódusa kivételt dob:" + e.Message);
            }
            Assert.AreEqual(expexted, actual, "A Side konstruktor a pontok számát nem tárolja el!");
        }


        [TestMethod()]
        public void SideKonstruktorEsToString()
        {
            Side side = new Side("jobb oldal", 3);
            string expexted = "A jobb oldal 3 pöttyöt tartalmaz.";
            string actual = string.Empty;

            try
            {
                actual = side.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("A pont ToString metódusa kivételt dob:" + e.Message);
            }
            Assert.AreEqual(expexted, actual, "A Side konstruktor vagy ToString nem megfelelően működik.");
        }
    }
}