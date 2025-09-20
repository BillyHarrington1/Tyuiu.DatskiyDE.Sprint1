using Tyuiu.DatskiyDE.Sprint1.Task6.V9.Lib;

namespace Tyuiu.DatskiyDE.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();          
            string input1 = "Hello world";
            string wait1 = "oHell dworl";
            string result1 = ds.MoveLetterToStart(input1);
            Assert.AreEqual(wait1, result1);          
        }
    }
}