using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Between_Two_Sets
{
    class Program
    {
        static void Main()
        {
            string[] s = new string[2];
            s = Console.ReadLine().Split(' ');
            int aSize = Convert.ToInt32(s[0]);
            int bSize = Convert.ToInt32(s[1]);
            string[] aAmount = new string[aSize];
            aAmount = Console.ReadLine().Split(' ');
            int[] a = new int[aSize];
            for(int i = 0; i < aSize; i++)
            {
                a[i] = Convert.ToInt32(aAmount[i]);
            }
            string[] bAmount = new string[bSize];
            bAmount = Console.ReadLine().Split(' ');
            int[] b = new int[bSize];
            for (int i = 0; i < bSize; i++)
            {
                b[i] = Convert.ToInt32(bAmount[i]);
            }
            int count = 0;
            for(int i = a[a.Length - 1]; i <= b[0]; i++)
            {
                int aCount = 0;
                int bCount = 0;
                int temp = i;
               for(int k = 0; k < a.Length; k++)
                {
                    if (i % a[k] == 0) aCount++;
                }
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j]%i == 0) bCount++;
                }
                if (aCount == a.Length&&bCount == b.Length)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
        
    }
}
