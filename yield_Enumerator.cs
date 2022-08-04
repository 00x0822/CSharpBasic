using System;
using System.Collections;
namespace MyList
{
   public class MyList
    {
        private int[] data = {1,2,3,4,5}; 

        public IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i < data.Length)
            {
                yield return data[i];
                i++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //(1) foreach 사용하여 Iteration
            var list = new MyList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // (2) 수동 Iteration
            IEnumerator it = list.GetEnumerator();
            it.MoveNext();
            Console.WriteLine(it.Current);
            it.MoveNext();
            Console.WriteLine(it.Current);
        }
    }
}
