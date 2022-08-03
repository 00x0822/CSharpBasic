using System;

namespace Arrary
{
    class Program
    {
        //1차 배열
        string[] players = new string[10];
        string[] Regions = { "서울", "경기", "부산" };

        //2차 배열 선언 및 초기화
        string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

        //3차 배열 선언
        string[,,] Cubes;

        
        //각 1차 배열 오소당 서로 다른 크기의 배열 할당 가능
       
        static void Main(string[] args)
        {
            int[][] A = new int[3][];

            A[0] = new int[2];
            A[1] = new int[3] { 1, 2, 3 };
            A[2] = new int[4] { 1, 2, 3, 4 };

            A[0][0] = 1;
            A[0][1] = 2;

            int sum = 0;
            int[] scores = { 80, 78, 60, 90, 100 };
            for (int i =0; i<scores.Length; i++)
            {
                sum += scores[i];
            }
            Console.WriteLine(sum);

            int sum2 = CalculateSum(scores);
            Console.WriteLine(sum);

        }

        static int CalculateSum(int[] scoresArray)
        {
            int sum = 0;
            for (int i =0; i< scoresArray.Length; i++)
            {
                sum += scoresArray[i];

            }
            return sum;
        }
    }
}
