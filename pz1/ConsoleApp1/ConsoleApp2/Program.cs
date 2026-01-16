using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz1_Fraction;
using System;

namespace FractionTests
{
    [TestClass]
    public class FractionUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [cite_start]
        public void Constructor_ZeroDenominator_ThrowsException() // [cite: 25, 26]
        {
            // Arrange & Act
            new Fraction(1, 0);
        }

        [TestMethod]
        public void Add_TwoSimpleFractions_ReturnsCorrectSum()
        {
            [cite_start]// Arrange [cite: 24]
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(1, 3);
            var expected = new Fraction(5, 6);

            // Act
            var result = f1.Add(f2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Equals_SameFractions_ReturnsTrue()
        {
            // Arrange
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(2, 4);

            // Act & Assert
            Assert.IsTrue(f1.Equals(f2));
        }

        [cite_start]// Додайте аналогічні методи для Subtract, Multiply, Divide, MultiplyByInt (всього мін. 7) [cite: 10]
    }
}