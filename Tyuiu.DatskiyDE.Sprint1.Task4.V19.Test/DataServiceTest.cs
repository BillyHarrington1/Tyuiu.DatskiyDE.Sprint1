﻿using Tyuiu.DatskiyDE.Sprint1.Task4.V19.Lib;
namespace Tyuiu.DatskiyDE.Sprint1.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = double.PositiveInfinity;
            var res = ds.Calculate (x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
