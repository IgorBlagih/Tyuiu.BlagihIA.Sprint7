
using Tyuiu.BlagihIA.Sprint7.V4.Lib;

namespace Tyuiu.BlagihIA.Sprint7.V4.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "DataSprint7", "InPutDataFileProjectV4.csv");

            int wait = 71770;

            string[,] tab = Class1.LoadFromFileData(path);
            int res = 0;
            for (int i = 1; i < tab.GetLength(0); i++)
            {
                for (int j = 3; j <=3; j++)
                {
                    res += Convert.ToInt32(tab[i, j]);
                }
            }

            Assert.AreEqual(wait, res);
        }
    }
}