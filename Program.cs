using System;
using System.Collections;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorld("sahini");

            //Console.WriteLine("please enter the number:");
            //int testsahin = Convert.ToInt32(Console.ReadLine());
            //Boolean kilicdaroqlu = true;

            //Console.WriteLine("Prime numbers between "
            //+ 0 + " and " + testsahin);
            //for (int k = 1; k <= testsahin; k++)
            //{
            //    //  loop the iterations for k times
            //    for (int i = 2; i < k; i++)
            //    {
            //        if ((k % i) == 0)
            //        {
            //            kilicdaroqlu = false;
            //            break;
            //        }
            //    }
            //    if (kilicdaroqlu == true)
            //    {
            //        Console.WriteLine(k);
            //    }
            //    kilicdaroqlu = true;
            //}
        }
        static void PrintHelloWorld(string name)
        {
            Console.WriteLine($"hello world {name}");
        }
    }
}
 


    
