using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace AnalizerClassTest
{
    [TestClass]
    public class AnalaizerClassTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("PROVIDER NAME", @"CONNECTION STRING", "TABLE", DataAccessMethod.Sequential)]
        public void GetPriority_ShouldReturnCorrectResult_WhenPassedWithCorrectData()
        {
            //Arrange
            object[] input =
            {
                (string)TestContext.DataRow["Input"]
            };
            int expected = (int)TestContext.DataRow["Output"];
            Type type = typeof(AnalaizerClass);
            MethodInfo method = type.GetMethod("GetPriority", BindingFlags.NonPublic | BindingFlags.Static);

            //Act
            byte result = (byte)method.Invoke("GetPriority", input);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
