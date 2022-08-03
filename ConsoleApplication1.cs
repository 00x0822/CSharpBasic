using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_Ex1
{
    class ConsoleApplication1
    {
        //필드 (클래스 내에서 공통적으로 사용되는 전역 변수)
        int globalVar;
        const int MAX = 1024;

        public void Method1()
        {
            //로컬변수
            int localVar;

            localVar = 100;//할당이 없으면 에러 발생

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            ConsoleApplication1 ca1 = new ConsoleApplication1();
            ca1.Method1();
        }
    }
    class CSVar
    {
        //상수
        const int MAX_VALUE = 1024;

        //readonly 필드
        readonly int Max;
        public CSVar()
        {
            Max = 1;
        }
    }
}
