using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            if(a<2)
            {
            Console.WriteLine("Hello World!");
            }
            else
            {
            Console.WriteLine("this is my first line");
            Console.Beep(1000,1000);//发出一个蜂鸣
            }
        }
    }
}
