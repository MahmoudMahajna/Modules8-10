namespace Rationals
{
    struct Rational
    {
        private int _numerator;
        private int _denominator;

        public Rational(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public Rational(int numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        public double Value => (double)_numerator / _denominator;

        public int Numerator => _numerator;

        public int Denominator => _denominator;

        public static implicit operator double(Rational r)
        {
            return r.Value;
        }
        public static implicit operator Rational(int i)
        {
            return new Rational(i);
        }

        public static Rational operator-(Rational r1,Rational r2)
        {
            var numerator = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;
            var denominator = r1.Denominator * r2.Denominator;

            return new Rational(numerator, denominator);
        }
        public static Rational operator/(Rational r1,Rational r2)
        {
            var numerator = r1.Numerator * r2.Denominator ;
            var denominator = r1.Denominator * r2.Numerator;

            return new Rational(numerator, denominator);
        }
        public static Rational operator+(Rational r1,Rational r2)
        {
            var numerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
            var denominator = r1.Denominator * r2.Denominator;

            return new Rational(numerator, denominator);
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            var numerator = r1.Numerator * r2.Numerator;
            var denominator = r1.Denominator * r2.Denominator;

            return new Rational(numerator, denominator);
        }

        public Rational Add(Rational r)
        {
            return this + r;
        }
        
        public Rational Mul(Rational r)
        {
            return this * r;
        }

        public void Reduce()
        {
            var factor = gcd(_numerator, _denominator);
            _numerator /= factor;
            _denominator /= factor;
        }

        private int gcd(int a, int b)
        {
            while (true)
            {
                if (b == 0) return a;
                var a1 = a;
                a = b;
                b = a1 % b;
            }
        }

        public override string ToString()
        {
            return $"numerator: {_numerator}\ndenominator: {_denominator}";
        }

        public override bool Equals(object obj)
        {
            Rational r = (Rational)obj;
            r.Reduce();
            Reduce();
            return Numerator == r.Numerator && Denominator == r.Denominator;
        }
    }
}