using Tyuiu.DatskiyDE.Sprint1.Task7.V22.Lib;

namespace Tyuiu.DatskiyDE.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {       
        [TestMethod]
        public void EdgeCaseCalculate()
        {
            DataService ds = new DataService();
            double x4 = Math.PI / 4;
            double y4 = Math.PI / 4;
            double wait4 = 1.0; 
            double res4 = ds.Calculate(x4, y4);
            Assert.AreEqual(wait4, res4, 0.0001);
        }               
    }
}