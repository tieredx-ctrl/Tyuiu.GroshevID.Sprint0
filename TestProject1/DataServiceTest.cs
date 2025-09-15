using Tyuiu.GroshevID.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GroshevID.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Илья";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Илья", res);
        }
    }
}
