using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ComplexNumber
{
    public int Real { get; set; }
    public int Imaginary { get; set; }

    public ComplexNumber(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    //this is operator overloading, for the + operator
    public static ComplexNumber operator +(ComplexNumber one, ComplexNumber two)
    {
        ComplexNumber answer = new ComplexNumber(0, 0);
        answer.Real = one.Real + two.Real;
        answer.Imaginary = one.Imaginary + two.Imaginary;

        return answer;
    }

    public static ComplexNumber operator -(ComplexNumber one, ComplexNumber two)
    {
        ComplexNumber answer = new ComplexNumber(0, 0);
        answer.Real = one.Real - two.Real;
        answer.Imaginary = one.Imaginary - two.Imaginary;

        return answer;
    }

    public static bool operator ==(ComplexNumber one, ComplexNumber two)
    {
        return (one.Real == two.Real && one.Imaginary == two.Imaginary);
    }

    public static bool operator !=(ComplexNumber one, ComplexNumber two)
    {
        return !(one.Real == two.Real && one.Imaginary == two.Imaginary);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }

    public static bool operator <(ComplexNumber one, ComplexNumber two)
    {
        double val1 = Math.Abs(Math.Sqrt(one.Real * one.Real + one.Imaginary * one.Imaginary));
        double val2 = Math.Abs(Math.Sqrt(two.Real * two.Real + two.Imaginary * two.Imaginary));
        return val1 < val2;
    }

    public static bool operator >(ComplexNumber one, ComplexNumber two)
    {
        double val1 = Math.Abs(Math.Sqrt(one.Real * one.Real + one.Imaginary * one.Imaginary));
        double val2 = Math.Abs(Math.Sqrt(two.Real * two.Real + two.Imaginary * two.Imaginary));
        return val1 > val2;
    }
}
