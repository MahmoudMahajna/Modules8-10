using System;

namespace Rationals
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                Rational r1 = new Rational(25, 5);
                Rational r2 = new Rational(17, 3);
                Rational r3 = new Rational(2, 3);

                Rational r4 = r1.Add(r2);
                double TOLERANCE = 0.000000001;
                Console.WriteLine((Math.Abs((double)r4.Numerator / r4.Denominator - (r1.Value + r2.Value)) < TOLERANCE).ToString());

                Rational r5 = r2.Mul(r3);
                Console.WriteLine((Math.Abs((double)r5.Numerator / r5.Denominator - r2.Value * r3.Value) < TOLERANCE).ToString());


                Rational r6 = new Rational(2, 4);
                r1.Reduce();
                r6.Reduce();

                Console.WriteLine(Math.Abs(r1.Value - 5) < TOLERANCE);
                Console.WriteLine(Math.Abs(r6.Value - 0.5) < TOLERANCE);

                Rational r7 = new Rational(20);
                Rational r8 = new Rational(7, 21);
                Console.WriteLine(r7.ToString() + "\n" + r8.ToString());

                r8.Reduce();
                Console.WriteLine(r8.ToString());

                Rational r9 = new Rational(21, 63);
                Console.WriteLine(r9.Equals(r8));

                //Operators tests
                Console.WriteLine(((new Rational(5)) * (new Rational(7))).Equals(new Rational(35)));
                Console.WriteLine(((new Rational(5)) - (new Rational(7))).Equals(new Rational(-2)));
                Console.WriteLine(((new Rational(5, 7)) * (new Rational(7, 3))).Equals(new Rational(35, 21)));
                Console.WriteLine(((new Rational(5, 1)) / (new Rational(2, 1))).Equals(new Rational(5, 2)));
                Console.WriteLine(((new Rational(5, 7)) + (new Rational(7, 3))).Equals(new Rational(64, 21)));

                //Casting tests
                Console.WriteLine((((Rational)5).Equals(new Rational(5, 1))));
                var y = (new Rational(35, 100));
                Console.WriteLine(y == 0.35);
                Console.WriteLine(((double)(new Rational(35, 100)) == 0.35));

                Rational rr = 15;
                double d = new Rational(45, 10);
                Console.WriteLine(rr.Equals(new Rational(15)));
                Console.WriteLine(rr.Equals((Rational)(15)));
                Console.WriteLine(d==4.5);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
