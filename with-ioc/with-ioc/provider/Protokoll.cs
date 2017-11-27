using System;

namespace with_ioc.provider
{
    public class Protokoll
    {
        public virtual void Log(string x, string y, int z, int sum) {
            Console.WriteLine($"x = {x}, y = {y}, z = {z}, sum = {sum}");
        }
    }
}