using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planets_Bar_Chart;

namespace PlanetsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Planets = new frmPlanets();
            var Expected = "*******";
            var Actual = Planets.GetDiameterAsAsterisks(7300);
            Assert.AreEqual(Expected, Actual);

        }
    }
}
