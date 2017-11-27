using System;
using System.Linq;
using Nancy.Hosting.Self;

namespace consolerunner
{
    internal class Program
    {
        public static void Main(string[] args) {
            var port = args.FirstOrDefault() ?? "8080";
            var url = $"http://localhost:{port}";

            using (var host = new NancyHost(new Uri(url))) {
                host.Start();
                Console.WriteLine($"Running on {url}");
                Console.WriteLine("Press <Enter> to stop...");
                Console.ReadLine();
            }
        }
    }
}