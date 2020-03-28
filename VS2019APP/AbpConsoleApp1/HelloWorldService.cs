using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;   //ITransientDependency

namespace AbpConsoleApp1
{
    public class HelloWorldService : ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
