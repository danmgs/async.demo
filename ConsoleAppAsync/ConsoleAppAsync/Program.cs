using System;
using System.Threading.Tasks;

namespace ConsoleAppAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            // var svc = new MyService();

            // var svc = new MyService2();
            // var svc = new MyService3();
            var svc = new MyService4();

            Task.Run(async () =>
            {
                await svc.MethodeAppelanteAsync();
            }).GetAwaiter().GetResult();

            Console.WriteLine("Push any key to exit ...");
            Console.ReadLine();
        }
    }
}
