using System;
using System.Collections.Generic;
using System.Collections;

namespace yield_Test
{
    class Program
    {
        static IEnumerable<int> GetNumber()
        {
            yield return 10;//첫번째 루프에서 리턴되는 값
            yield return 20;// 두번째 루프에서 리턴되는 값
            yield return 30; // 세번째 루프에서 리턴되는 값
        }

        private int[] data = { 1, 2, 3, 4, 5 };

        public IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i < data.Length)
            {
                yield return data[i];
                i++;
            }
        }
        static void Main(string[] args)
        {
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);
            }

          

        }
    }
}
