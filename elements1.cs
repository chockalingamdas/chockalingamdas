using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class elements1 : elements
    {
        public void exe0()
        {
            exe1();
        }
        protected void exe1()
        {
            Console.WriteLine("input the storing elements");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] elements = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("elements :", i);
                elements[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("storing elements are");
            for (int i = 0; i < n; i++)
            {
                Console.Write(elements[i] + ",");
            }
        }
        public void exe2()
        {
            Console.WriteLine("\narangeing elements small to large");
            int[] num = new int[] { 5, 6, 7, 3, 2, 9 };
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[j] < num[i])
                    {
                        int a = 0;
                        a = num[j];
                        num[j] = num[i];
                        num[i] = a;
                    }
                }
                Console.Write(num[i] + ",");
            }
            Console.WriteLine("\narrenging elements lorge to small");
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[j] > num[i])
                    {
                        int a = 0;
                        a = num[j];
                        num[j] = num[i];
                        num[i] = a;
                    }
                }
                Console.Write(num[i] + ",");
            }
        }
       internal void exe3()
        {
            Console.WriteLine("\ncopy of the element one array to another array");
            int[] arr1 = new int[9] { 1, 6, 7, 9, 3, 4, 2, 5, 8 };
            int[] arr2 = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("\nelement in the array");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]);
            }
            Console.WriteLine("\ncopy elements");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr2 == arr1)
                {
                    int a = 0;
                    a = arr2[i];
                    arr2[i] = arr1[i];
                    arr1[i] = a;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr1[i]);
            }
        }
    }
}