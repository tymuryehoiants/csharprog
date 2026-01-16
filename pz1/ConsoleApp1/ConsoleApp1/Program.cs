using System;

namespace Lab1_Fraction
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        [cite_start]// Властивості замість методів доступу [cite: 19]
        public int Numerator => _numerator;
        public int Denominator => _denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) throw new ArgumentException("Denominator cannot be zero.");
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction Add(Fraction other) => throw new NotImplementedException(); // [cite: 16]
        public Fraction Subtract(Fraction other) => throw new NotImplementedException();
        public Fraction Multiply(Fraction other) => throw new NotImplementedException();
        public Fraction Divide(Fraction other) => throw new NotImplementedException();

        public Fraction MultiplyByInt(int number) => throw new NotImplementedException();
        public Fraction AddInt(int number) => throw new NotImplementedException();

        public override bool Equals(object obj) => throw new NotImplementedException(); // [cite: 17]
        public override string ToString() => throw new NotImplementedException(); // [cite: 18]
    }
}