using System;
using Volo.Abp;  //AbpApplicationFactory

namespace AbpConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var application = AbpApplicationFactory.Create<AppModule>())
            {
                application.Initialize();

                Console.WriteLine("Press ENTER to stop application...");
                Console.ReadLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
