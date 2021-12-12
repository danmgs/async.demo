using System;
using System.Threading.Tasks;

namespace ConsoleAppAsync
{
    public class MyService
    {

        public async Task MethodeAppelanteAsync()
        {
            Console.WriteLine("Je vais à la gare");

            DateTime resultDt = await MethodeAsync();

            Console.WriteLine($"Je quitte la gare après {resultDt}");
        }

        private async Task<DateTime> MethodeAsync()
        {
            Console.WriteLine("Je suis en train d'attendre ...");

            await Task.Delay(4000);

            DateTime resultDt = DateTime.Now;

            Console.WriteLine($"J'ai fini d'attendre à {resultDt}");

            return resultDt;
        }

    }
}
