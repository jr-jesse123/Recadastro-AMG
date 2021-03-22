using Config;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RecadastroAMG.Web.Data;
using Microsoft.FSharp.Core;
using  Domain;

namespace RecadastroAMG.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<Func<int>>(() => 1);
            //services.AddTransient<Config.CepValidator>(provider => CepValidator.NewCepValidator(FuncConvert.FromFunc<string,bool>((str) => true)));
            //services.AddTransient(provider => CepValidator.NewCepValidator(FuncConvert.FromFunc<string, bool>((str) => true)));

            services.AddDefaultValidators("");
            //services.Add<CepValidator>(null);

            services.AddTransient<CEPModule.CepValidatorNet>(sp => CEPModule.CepValidatorNet.NewCepValidator(FuncConvert.FromFunc<string, bool>((x) => false))); ;
           
            

            //var change = Microsoft.FSharp.Core.FuncConvert.FromFunc<string, string>((str) => "foda-se");

            //var teste = Domain.Iteste4.NewVish(change);

            //var teste2 = Domain.Iteste3.NewVish("");


            //aqui nós podemos registar uma classe ou uma função com as depencencias resolvidas.
            //d e forma que ao ser solicitada a função base ela seja entre  resolvida.\\\\\\
            //services.AddSingleton<>
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, Func<int> func, CEPModule.CepValidatorNet validador, string teste)
        {
            var x = func.Invoke();

            var y = validador;

            var z = validador.Item.Invoke("");
            


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
