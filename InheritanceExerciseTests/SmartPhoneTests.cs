using InheritanceExercise;

namespace InheritanceExerciseTests
{
    [TestClass]
    public class SmartPhoneTests
    {
        private SmartPhone testSmartPhone;
        private string manufacturer = "Samsung";
        private string model = "Galaxy S7";
        private string os = "Android";

        [TestInitialize]
        public void SmartPhoneTestInit()
        {
            testSmartPhone = new SmartPhone(manufacturer, model, os);
        }

        [TestMethod]
        public void SmartPhone_ConstructorSetsFields()
        {
            Assert.AreEqual(manufacturer, testSmartPhone.Manufacturer);
            Assert.AreEqual(model, testSmartPhone.Model);
            Assert.AreEqual(os, testSmartPhone.OperatingSystem);
        }

        [TestMethod]
        public void SmartPhone_InitializesWithZeroBattery()
        {
            Assert.AreEqual(testSmartPhone.CurrentBatteryPercentage, 0);
        }

        [TestMethod]
        public void SmartPhone_CanRechargeBattery()
        {
            testSmartPhone.RechargeBattery();
            Assert.AreEqual(testSmartPhone.CurrentBatteryPercentage, 100);
        }

        [TestMethod]
        public void SmartPhone_CanCall()
        {
            Assert.AreNotEqual(testSmartPhone.Call(), "");
        }

        [TestMethod]
        public void SmartPhone_InitializesIsWaterproofToFalse()
        {
            Assert.IsFalse(testSmartPhone.IsWaterproof);
        }
    }
}
