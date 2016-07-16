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

        public Rational Add(Rational r)
        {
            var numerator = _numerator * r.Denominator + r.Numerator * _denominator;
            var denominator = _denominator * r.Denominator;

            return new Rational(numerator, denominator);
        }

        public Rational Mul(Rational r)
        {
            var numerator = _numerator * r.Numerator;
            var denominator = _denominator * r.Denominator;

            return new Rational(numerator, denominator);
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