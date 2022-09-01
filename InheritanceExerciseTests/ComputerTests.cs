using InheritanceExercise;

namespace InheritanceExerciseTests
{
    [TestClass]
    public class ComputerTests
    {
        private Computer testComputer;
        private string manufacturer = "Apple";
        private string model = "iMac Pro";
        private string os = "iOS";

        [TestInitialize]
        public void ComputerTestInit()
        {
            testComputer = new Computer(manufacturer, model, os);
        }

        [TestMethod]
        public void Computer_ConstructorSetsFields()
        {
            Assert.AreEqual(manufacturer, testComputer.Manufacturer);
            Assert.AreEqual(model, testComputer.Model);
            Assert.AreEqual(os, testComputer.OperatingSystem);
        }

        [TestMethod]
        public void Computer_CanChangeOperatingSystem()
        {
            testComputer.ChangeOperatingSystem("Debian");
            Assert.AreEqual(testComputer.OperatingSystem, "Debian");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Computer_ThrowsExceptionOnChangeToSameOperatingSystem()
        {
            testComputer.ChangeOperatingSystem(testComputer.OperatingSystem);
            Assert.Fail("Expected exception: New OS must be different from current OS!");
        }

        [TestMethod]
        public void Computer_CanChangeScreenDimensions()
        {
            testComputer.SetScreenDimensions(20f, 16f);
            Assert.AreEqual(testComputer.ScreenDimensions.X, 20f, 0.001f);
            Assert.AreEqual(testComputer.ScreenDimensions.Y, 16f, 0.001f);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Computer_ThrowsExceptionOnInvalidScreenSize()
        {
            testComputer.SetScreenDimensions(-5f, 10.5f);
            Assert.Fail("Expected exception: Invalid screen dimensions!");
        }


        [TestMethod]
        public void Computer_InstancesAreAssignedUniqueIds()
        {
            Computer otherTestComputer = new Computer(testComputer.Manufacturer, testComputer.Model, testComputer.OperatingSystem);
            Assert.AreNotEqual(testComputer.Id, otherTestComputer.Id);
            Assert.AreNotEqual(testComputer, otherTestComputer);
        }
    }
}