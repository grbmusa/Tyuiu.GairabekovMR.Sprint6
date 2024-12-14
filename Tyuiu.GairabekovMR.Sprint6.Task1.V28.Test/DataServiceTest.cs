using Tyuiu.GairabekovMR.Sprint6.Task1.V28.Lib;
namespace Tyuiu.GairabekovMR.Sprint6.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double result = res[0];
            Assert.AreEqual(4.67, result);
        }
    }
}