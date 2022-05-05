using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LineComparison
    {
        double LineLength1 = 0;
        double LineLength2 = 0;
       public void LengthOfLine()
        {
            Console.WriteLine("Enter the co-ordinates of first line");
            Console.Write("x1= ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1= ");
            int y1 = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("x2= ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2= ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the co-ordinates of second line");
            Console.Write("x3= ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3= ");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("x4= ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y4= ");
            int y4 = Convert.ToInt32(Console.ReadLine());

            //length of line 1
            double Length1 = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
             LineLength1=Math.Sqrt(Length1);
            Console.WriteLine("Length of line 1 : " + LineLength1);
            //length of line 2
            double Length2 = Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2);
            LineLength2 = Math.Sqrt(Length2);
            Console.WriteLine("Length of line 2 : " + LineLength2);

        }

        public void Compare2Lines()
        {
            if (LineLength1 < LineLength2)
            {
                Console.WriteLine("Line 2 is greater than Line 1");
            }
            else if (LineLength1 > LineLength2)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine("Lines are equal");
            }
        }


    }
}
