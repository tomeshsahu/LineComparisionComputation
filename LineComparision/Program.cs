
using System;
namespace LineComparision;

class program
{
    public static void Main(String[] args)
    {
        LineComp Comparision = new LineComp(2,5,6,8);
        Comparision.CalculateLength();

        LineComp Line1=new LineComp(2,5,6,8);
       double l1= Line1.CalculateLength();
        LineComp Line2 = new LineComp(2, 5, 6, 8);
       double l2=Line2.CalculateLength();
     
        if (l1.CompareTo(l2) == 0)
        {
            Console.WriteLine("Both Lines are equals ");
        }
        else if (l2.CompareTo(l1) > 0)
        {
            Console.WriteLine("Both Lines are not equals ");
        }
    }
}
