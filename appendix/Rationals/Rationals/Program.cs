using System;

namespace Rationals
{
    class Program
    {

        static void Main(string[] args)
        {
            
           
            Rational r1=new Rational(25,5);
            Rational r2=new Rational(17,3);
            Rational r3=new Rational(2,3);

            Rational r4 = r1.Add(r2);
            double TOLERANCE=0.000000001;
            Console.WriteLine((Math.Abs((double)r4.Numerator/r4.Denominator - (r1.Value+r2.Value)) < TOLERANCE).ToString());

            Rational r5 = r2.Mul(r3);
            Console.WriteLine((Math.Abs((double)r5.Numerator / r5.Denominator - r2.Value * r3.Value) < TOLERANCE).ToString());


            Rational r6=new Rational(2,4);
            r1.Reduce();
            r6.Reduce();

            Console.WriteLine(Math.Abs(r1.Value - 5) < TOLERANCE);
            Console.WriteLine(Math.Abs(r6.Value - 0.5) < TOLERANCE);

            Rational r7=new Rational(20);
            Rational r8=new Rational(7,21);
            Console.WriteLine(r7.ToString()+"\n"+r8.ToString());

            r8.Reduce();
            Console.WriteLine(r8.ToString());

            Rational r9=new Rational(21,63);
            Console.WriteLine(r9.Equals(r8));
        }
    }
}
