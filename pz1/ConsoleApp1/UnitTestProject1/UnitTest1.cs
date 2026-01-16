using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_Fraction;
using System;

namespace FractionTests
{
    [TestClass]
    public class FractionUnitTest
    {
        [TestMethod]
        public void Constructor_ZeroDenominator_ThrowsArgumentException()
        {
            
            Assert.ThrowsException<ArgumentException>(() => new Fraction(1, 0));
        }

        [TestMethod]
        public void Add_SimpleFractions_ReturnsCorrectSum()
        {
           
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(1, 3);
            var expected = new Fraction(5, 6);

            
            var result = f1.Add(f2);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Subtract_Fractions_ReturnsCorrectDifference()
        {
            
            var f1 = new Fraction(3, 4);
            var f2 = new Fraction(1, 4);
            var expected = new Fraction(2, 4);

            
            var result = f1.Subtract(f2);

           
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_TwoFractions_ReturnsCorrectProduct()
        {
            
            var f1 = new Fraction(2, 3);
            var f2 = new Fraction(3, 5);
            var expected = new Fraction(6, 15);

            
            var result = f1.Multiply(f2);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_Fractions_ReturnsCorrectQuotient()
        {
            
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(1, 3);
            var expected = new Fraction(3, 2);

            
            var result = f1.Divide(f2);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Equals_EquivalentFractions_ReturnsTrue()
        {
            
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(2, 4);

            
            Assert.IsTrue(f1.Equals(f2));
        }

        [TestMethod]
        public void AddInt_FractionAndInteger_ReturnsCorrectSum()
        {
            
            var f = new Fraction(1, 2);
            int number = 1;
            var expected = new Fraction(3, 2);

            
            var result = f.AddInt(number);

            
            Assert.AreEqual(expected, result);
        }
    }
}