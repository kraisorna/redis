using System;
using System.IO;
using ServiceStack.Redis;

namespace RedisConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var redisManager = new RedisManagerPool("localhost:6379");
            var redis = redisManager.GetClient();

            using (StreamReader r = new StreamReader("example.json"))
            {
                string json = r.ReadToEnd();
                //Console.WriteLine(json);
                //redis.SetValue("json",json);
            }

            var x1 = redis.GetValue("foo");
            Console.WriteLine(x1);

            var x2 = redis.GetValue("json");
            Console.WriteLine(x2);

            Console.ReadLine();
        }
    }
}
