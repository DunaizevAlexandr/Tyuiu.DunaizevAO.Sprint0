using Tyuiu.DunaizevAO.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DunaizevAO.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessegeValid()
        {
            var name = "Игорь";
            var res = DataService.GetMassage(name);

            Assert.AreEqual("Привет, Игорь", res);
        }
    }
}
