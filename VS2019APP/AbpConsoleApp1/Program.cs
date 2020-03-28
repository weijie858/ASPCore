using System;
using Volo.Abp;  //AbpApplicationFactory
using Microsoft.Extensions.DependencyInjection;
namespace AbpConsoleApp1
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    using (var application = AbpApplicationFactory.Create<AppModule>())
        //    {
        //        application.Initialize();

        //        #region 1
        //        //Console.WriteLine("Press ENTER to stop application...");
        //        //Console.ReadLine(); 
        //        #endregion

        //        //Resolve a service and use it
        //        var helloWorldService =
        //            application.ServiceProvider.GetService<HelloWorldService>();
        //        helloWorldService.SayHello();

        //        Console.WriteLine("Press ENTER to stop application...");
        //        Console.ReadLine();

        //    }
        //   //Console.WriteLine("Hello World!");
        //}


        static void Main(string[] args)
        {
            using
                (var application = AbpApplicationFactory.Create<AppModule>
                (
                    options =>
                    {
                        options.UseAutofac(); //Autofac integration
                    }
            )
                )
            {
                application.Initialize();

                //Resolve a service and use it
                var helloWorldService =
                    application.ServiceProvider.GetService<HelloWorldService>();
                helloWorldService.SayHello();

                Console.WriteLine("Press ENTER to stop application...");
                Console.ReadLine();
            }
        }
    }
}
