using System;
using static System.Console;
namespace _1904
{
    class Program
    {
        static int func(int N, int[] arr)
        {
            if (N == 1) return 1;
            if (N == 2) return 2;
            if (arr[N - 1] != 0) return arr[N - 1] % 15746;
            arr[N - 1] = func(N - 1, arr) + func(N - 2, arr);
            return arr[N-1] % 15746;
        }
        static void Main(string[] args)
        {
            string inputdata = ReadLine();
            int num;
            num = int.Parse(inputdata);
            
            int[] list = new int[num];
            for (int i = 0; i < num; i++)
            {
                list[i] = 0;
            }
            WriteLine(func(num, list));
        }
    }
}
