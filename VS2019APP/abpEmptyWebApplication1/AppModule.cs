using Microsoft.AspNetCore.Builder; //GetApplicationBuilder(
using Microsoft.Extensions.Hosting;  //IsDevelopment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;//ApplicationInitializationContext
using Volo.Abp.AspNetCore.Mvc; //AbpAspNetCoreMvcModule
using Volo.Abp.Autofac;//AbpAutofacModule
using Volo.Abp.Modularity;  //DependsOn

namespace abpEmptyWebApplication1
{
    [DependsOn(typeof(AbpAspNetCoreMvcModule))]
    [DependsOn(typeof(AbpAutofacModule))]
    public class AppModule : AbpModule
    {
        public override void OnApplicationInitialization(
            ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseMvcWithDefaultRouteAndArea();
        }
    }
}
