using System;

namespace BubleSort
{
    class Program
    {
        public static int[] BubleSort( int [] vs)
        {
            for (int i = 0; i < vs.Length -1 ; i++)
            {
                for (int j = 0; j < vs.Length - i - 1; j++)
                {
                    if (vs[j] > vs[j +1])
                    {
                         int temp = vs[j];
                        vs[j] = vs[j + 1];
                        vs[j + 1] = temp;
                    }

                }
            }
            return vs;
        }
        static void Main(string[] args)
        {
            int[] vs = new int[]  {1,5,7,3,2 };
            
            BubleSort(vs);
            
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }
        }
    }
}
