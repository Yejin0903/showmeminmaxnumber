using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
	class Program
	{
		static void Main(string[] args)
		{
            int i;
            int[] num= new int[50]; 
            int max = 0; 
            int min = 0; 

            for (i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력하세요 : ");
                num[i] = int.Parse(Console.ReadLine());
            } 

            //최대값
            for (i = 0; i < 5; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
              }
            } 

            //최소값
            min = num[0];
            for (i = 0; i < 5; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
              }
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("가장 큰 수 : " + max);
            Console.WriteLine("가장 작은 수 : " + min);
        }
    }
	}