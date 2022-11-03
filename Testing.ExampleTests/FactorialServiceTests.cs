using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Example.Tests
{
    [TestClass()]
    public class FactorialServiceTests
    {
        [TestMethod()]
        public void TestFactorialZero()
        {
            //Arrange
            FactorialService service = new FactorialService();

            //Act
            int result = service.Calculate(0);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestFactorialFive()
        {
            //Arrange
            FactorialService service = new FactorialService();

            //Act
            int result = service.Calculate(5);

            //Assert
            Assert.AreEqual(120, result);
        }
    }
}