using System;

namespace ComplexLibrary
{
    public class Complex
    {
        private double _real;
        private double _imaginary;

        public double Real { get => _real; set => _real = value; }
        public double Imaginary { get => _imaginary; set => _imaginary = value; }

        public Complex() : this(0, 0) { }
        public Complex(double real, double imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public override string ToString() => $"{_real} + {_imaginary}i";

        public static Complex operator +(Complex a, Complex b) => new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        public static Complex operator -(Complex a, Complex b) => new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        public static Complex operator *(Complex a, Complex b) =>
            new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + a.Imaginary * b.Real);

        public static Complex operator +(Complex a, double b) => new Complex(a.Real + b, a.Imaginary);
        public static Complex operator *(Complex a, double b) => new Complex(a.Real * b, a.Imaginary * b);

        public static bool operator ==(Complex a, Complex b) => a.Real == b.Real && a.Imaginary == b.Imaginary;
        public static bool operator !=(Complex a, Complex b) => !(a == b);

        public static bool operator true(Complex c) => c.Real != 0 || c.Imaginary != 0;
        public static bool operator false(Complex c) => c.Real == 0 && c.Imaginary == 0;

        public static implicit operator Complex(double d) => new Complex(d, 0);
        public static explicit operator double(Complex c) => Math.Sqrt(c.Real * c.Real + c.Imaginary * c.Imaginary);

        public override bool Equals(object obj) => obj is Complex c && this == c;

        
        public override int GetHashCode()
        {
            unchecked
            {
                return (_real.GetHashCode() * 397) ^ _imaginary.GetHashCode();
            }
        }
    }
}