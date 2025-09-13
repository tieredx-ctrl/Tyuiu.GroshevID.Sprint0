using System;

using Tyuiu.GroshevID.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GroshevID.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetMessageValid()
        {
            var name = "����";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("������, ����", res);
        }
    }
}