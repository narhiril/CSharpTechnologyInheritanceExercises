using InheritanceExercise;

namespace InheritanceExerciseTests
{
    [TestClass]
    public class LaptopTests
    {
        private Laptop testLaptop;
        private string manufacturer = "Asus";
        private string model = "G75VW";
        private string os = "Windows 8.1"; //RIP my laptop from college

        [TestInitialize]
        public void LaptopTestInit()
        {
            testLaptop = new Laptop(manufacturer, model, os); 
        }

        [TestMethod]
        public void Laptop_ConstructorSetsFields()
        {
            Assert.AreEqual(manufacturer, testLaptop.Manufacturer);
            Assert.AreEqual(model, testLaptop.Model);
            Assert.AreEqual(os, testLaptop.OperatingSystem);
        }

        [TestMethod]
        public void Laptop_InitializesWithZeroBattery()
        {
            Assert.AreEqual(testLaptop.CurrentBatteryPercentage, 0);
        }

        [TestMethod]
        public void Laptop_CanRechargeBattery()
        {
            testLaptop.RechargeBattery();
            Assert.AreEqual(testLaptop.CurrentBatteryPercentage, 100);
        }
    }
}
