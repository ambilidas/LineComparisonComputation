using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LineComparison
    {
       public void LengthOfLine()
        {
            Console.WriteLine("Enter the co-ordinates of first point");
            Console.Write("x1= ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1= ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the co-ordinates of second point");
            Console.Write("x2= ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2= ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double Length = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            double LineLengh=Math.Sqrt(Length);
            Console.WriteLine("Length of line : " + LineLengh);
        }
    }
}
