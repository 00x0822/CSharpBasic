using System;

namespace _20220805
{
    class Program1
    {
        private void Calculate(int a)
        {
            a *= 2;
        }
        static void Main(string[] args)
        {
            Program1 p = new Program1();

            int val = 100;
            p.Calculate(val);
        }
    }

    class Program2
    {
        //ref 정의
        static double GetData(ref int a, ref double b)
        { return ++a * ++b; }

        //out 정의
        static bool GetData(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
            return true;
        }

        static void Main(String[] args)
        {
            //ref 사용. 초기화 필요.
            int x = 1;
            double y = 1.0;
            double ret = GetData(ref x, ref y);

            //out 사용. 초기화 불필요
            int c, d;
            bool bret = GetData(10, 20, out c, out d);
        }
    }
}
