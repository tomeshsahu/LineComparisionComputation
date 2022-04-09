
using System;
namespace LineComparision;

class program
{
    public static void Main(String[] args)
    {
        LineComp Comparision = new LineComp(2,5,6,8);
        Comparision.CalculateLength();

        LineComp Line1=new LineComp(2,5,6,8);
        Line1.CalculateLength();
        LineComp Line2 = new LineComp(2, 5, 6, 8);
        Line2.CalculateLength();
        if (Line1.Equals(Line2))
        {
            Console.WriteLine("Both Lines are equals ");
        }
        else
        {
            Console.WriteLine("Both Lines are not equals ");
        }
    }
}
