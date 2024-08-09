using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackBalanceHW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBalanceHW.Tests
{
    [TestClass()]
    public class BalanceTests
    {
        [TestMethod()]
        public void IsBalancedTest_IfEmpty_ReturnTrue()
        {
            // Arrange
            string expression = "";

            // Act
            bool result = Program.IsBalanced(expression);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void IsBalancedTest_SimpleBalanced_ReturnTrue()
        {
            // Arrange
            string expression = "()";

            // Act
            bool result = Program.IsBalanced(expression);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsBalancedTest_SimpleUnbalanced_ReturnFalse()
        {
            // Arrange
            string expression = "(";

            // Act
            bool result = Program.IsBalanced(expression);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsBalancedTest_NestedBalanced_ReturnTrue()
        {
            // Arrange
            string expression = "{[()]}";

            // Act
            bool result = Program.IsBalanced(expression);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsBalancedTest_NestedUnbalanced_ReturnFalse()
        {
            // Arrange
            string expression = "{[(])}";

            // Act
            bool result = Program.IsBalanced(expression);

            // Assert
            Assert.IsFalse(result);
        }


    }
}