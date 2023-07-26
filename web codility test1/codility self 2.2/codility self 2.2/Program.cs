using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Solution
    {
        public static int solution(int[] A)
        {
            // Implement your solution here
            int ret = 0;
            Dictionary<int, int> counts = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] == A[j] && i != j)
                    {
                        count++;
                    }
                }
                counts.Add(i, count);
            }
            for (int i=0;i<A.Length;i++)
            {
                if(counts[i]==1)
            {
                ret = A[i];
            }
            }
            //foreach (int val in counts.Values)
            //{
            //    if (val < 2 && val!=0)
            //    {
            //        ret = val;
            //    }
            //}
            return ret;
        }
    

    static void Main(string[] args)
        {
        int[] A = { 9, 3, 9, 3, 9, 7, 9 };
        solution(A);
        Console.WriteLine(solution(A));
        Console.ReadLine();
        }

    }

