using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary2;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void CiliderArea_3and5_15returned()
        {
            int S = 3;
            int h = 5;
            int expected = 15;

            Geometry g = new Geometry();
            int actual = g.CiliderArea(S, h);

            Assert.AreEqual(expected, actual);

        }
    }
}

