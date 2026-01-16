using System;

namespace Lab1_Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public int Numerator => _numerator;
        public int Denominator => _denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) throw new ArgumentException("Знаменник не може бути 0");
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction Add(Fraction other)
        {
            return new Fraction(_numerator * other._denominator + other._numerator * _denominator,
                                _denominator * other._denominator);
        }

        public Fraction Subtract(Fraction other)
        {
            return new Fraction(_numerator * other._denominator - other._numerator * _denominator,
                                _denominator * other._denominator);
        }

        public Fraction Multiply(Fraction other)
        {
            return new Fraction(_numerator * other._numerator, _denominator * other._denominator);
        }

        public Fraction Divide(Fraction other)
        {
            if (other._numerator == 0) throw new DivideByZeroException();
            return new Fraction(_numerator * other._denominator, _denominator * other._numerator);
        }

        public Fraction MultiplyByInt(int number)
        {
            return new Fraction(_numerator * number, _denominator);
        }

        public Fraction AddInt(int number)
        {
            return new Fraction(_numerator + number * _denominator, _denominator);
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction other)
            {
                return _numerator * other._denominator == other._numerator * _denominator;
            }
            return false;
        }

        public override int GetHashCode() => (_numerator, _denominator).GetHashCode();

        public override string ToString() => $"{_numerator}/{_denominator}";
    }
}