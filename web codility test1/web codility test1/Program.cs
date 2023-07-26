using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_codility_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 6, 4, 1, 7, 10 };
            Console.WriteLine(solution2(A));
            Console.ReadLine();
        }
        static int changes(int[] A)
        {  int cha= 0;
            int check = 0;
           int  origanalreturn = 0;
            for (int i = 0; i < A.Length; i+=4)
            {
                if(A[i]<0)
                {
                    A[i] *= -1;
                    cha++;
                }
                else if(A[i]==0)
                {
                    check = -1;
                    break;
                }
            }
            for (int i = 2; i < A.Length; i += 4)
            {
                if (A[i] > 0)
                {
                    A[i] *= -1;
                    cha++;
                }
                else if (A[i] == 0)
                {
                    check = -1;
                    break;
                }
            }
            for (int i = 1; i < A.Length; i += 2)
            {
                    if (A[i] != 0)
                    {
                        A[i] *= 0;
                        cha++;
                    }
                    
            }
            if(check==-1)
            {
                origanalreturn = -1;
            }
            else
            {
                origanalreturn = cha;
            }
            return origanalreturn;
        }
        static int solution2(int[] A)
        {     
            int[] B = (int[])A.Clone();
            int chal=0;
            Array.Sort(A);
            for(int i=0;i<A.Length;i++)
            {
                if(A[i]!= B[i])
                {
                    chal++;
                }
            }
            return chal;

        }
          
    }
}
