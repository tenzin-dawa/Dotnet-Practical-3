using System;
namespace mainprogram
{
    class Fraction
    {
        public static void Main()
        {
            double a;
            Console.WriteLine("Please enter the numerator ?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the denumerator ?");
            int denum = Convert.ToInt32(Console.ReadLine());
            if(denum==0)
            {
                throw new DivideByZeroException();
            }
            intdiv(num,denum);
            a = floatdiv(num,denum);
            Console.WriteLine("Floating point division result = " +a);
            mixedfraction(num,denum);
        }
        public static void intdiv(int x,int y)
        {
            Console.WriteLine($"Integer division result = {(int)x/y} with a remainder {x%y}");
        }
        public static double floatdiv(int x,int y)
        {
            return (float)x/y;
        }
        public static void mixedfraction(int x,int y)
        {
            int Num = (int)x/y;
            Console.WriteLine($"The result as a mixed fraction is = {Num} {x%y}/{y}");
        }
    }
}

