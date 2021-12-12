using System;
using System.Threading.Tasks;

namespace ConsoleAppAsync
{
    public class MyService4
    {

        public async Task MethodeAppelanteAsync()
        {
            Console.WriteLine("Je vais à la gare");

            Task<DateTime> t = MethodeAsync();

            LireUnJournal();

            BoireUnCafé();

            //await t;

            throw new Exception("Problème de train !");

            Console.WriteLine($"Je quitte la gare après {t.Result}");
        }

        private void LireUnJournal()
        {
            Console.WriteLine("Je lis un journal");
        }

        private void BoireUnCafé()
        {
            Console.WriteLine("Je bois un cafe");
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
