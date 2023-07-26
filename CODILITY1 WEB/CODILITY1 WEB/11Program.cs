using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODILITY1_WEB
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //1ST 100%
        public bool solution(string S)
        {
            // Implement your solution here
            bool ret = true;
            int point = 0;
            for(int i=0;i<S.Length;i++)
            {
                if (S[i] =='b')
                {
                    point = i;
        
                }
                if (S[i] == 'a'&&i>point)
                {
                    ret = false;
                }
               
            }
            return ret;
            2ND//55%
             public int solution(string S)
            {
                // Implement your solution here
                int[] counts = new int[S.Length];
                int dif = 0;
                int ret = 0;

                for (int i = 0; i < S.Length; i++)
                {   //
                    if (S[i] =='^')
                    {
                        counts[0]++;
                    }
                    else if (S[i] == 'v')
                    {
                        counts[1]++;
                    }
                    else if (S[i] == '<')
                    {
                        counts[2]++;
                    }
                    else if (S[i] == '>')
                    {
                        counts[3]++;
                    }
                }
                dif = counts.Max();

                ret = S.Length - dif;
                return ret;


            }

            //3


            public int solution(int N)
            {
                // Implement your solution here
                33%
                N = N + 1;
                string num = Convert.ToString(N);

                int ret = N;
                for (int i = 2;i<num.Length-1;i++)
                {
                    if (num[i - 1] == num[i - 2])
                    {
                        while (num[i - 1] == num[i - 2])
                        {
                            N++;
                            num = num = Convert.ToString(N);
                        }
                    }
                }
                    
                ret = N;

                return ret;

            }
            


        }
    }
}
