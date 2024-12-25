using Project.V1.Lib;
using System.IO;
namespace Project.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.GetData(@"C:\DataSprint6\Test.CSV");
            string[,] wait = { { "П765РО72", "Lada", "Белый", "44" } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
