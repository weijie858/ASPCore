using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Autofac;   //AbpAutofacModule
using Volo.Abp.Modularity;  //AbpModule

namespace AbpConsoleApp1
{
    [DependsOn(typeof(AbpAutofacModule))] //Add dependency to the AbpAutofacModule
    public class AppModule:AbpModule
    {
    }
}
