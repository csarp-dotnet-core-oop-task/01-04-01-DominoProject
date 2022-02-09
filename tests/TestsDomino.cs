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
    public class TestsDomino
    {
        [TestMethod()]
        public void DominoKonstruktor()
        {
            try
            {
                Side rightSide = new Side("jobb oldal", 3);
                Side leftSide = new Side("bal oldal", 8);
                Domino d = new Domino(rightSide, leftSide); ;
            }
            catch (Exception e)
            {
                Assert.Fail("A domino konstruktor kivételt dob:" + e.Message);
            }
        }


        [TestMethod()]
        public void DominoKonstruktorOsszesPont()
        {
            Side rightSide = new Side("jobb oldal", 3);
            Side leftSide = new Side("bal oldal", 8);
            Domino d = new Domino(rightSide, leftSide); ;
            int expexted = 11;
            int actual=0;

            try
            {
                actual = d.TotalPoint;
            }
            catch (Exception e)
            {
                Assert.Fail("A domino get metódusa kivételt dob:" + e.Message);
            }
            Assert.AreEqual(expexted, actual, "A domino konstruktor az összes pontok számát nem adja meg");
        }


        [TestMethod()]
        public void DominoKonstruktorEsToString()
        {
            Side rightSide = new Side("jobb oldal", 3);
            Side leftSide = new Side("bal oldal", 8);
            Domino d = new Domino(rightSide, leftSide); ;
            string expexted = "A jobb oldal 3 pöttyöt tartalmaz.\nA bal oldal 8 pöttyöt tartalmaz.\nA dominon lévő pontok száma: 11 pont.";
            string actual = string.Empty;

            try
            {
                actual = d.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("A domino ToString metódusa kivételt dob:" + e.Message);
            }
            Assert.AreEqual(expexted, actual, "A domino konstruktor vagy ToString nem megfelelően működik.");
        }
    }
}