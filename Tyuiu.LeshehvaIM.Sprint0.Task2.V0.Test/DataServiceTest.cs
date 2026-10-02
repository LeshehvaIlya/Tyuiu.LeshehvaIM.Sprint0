using Tyuiu.LeshehvaIM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.LeshehvaIM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassegeValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Илья";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Илья", res);
        }
    }
}
