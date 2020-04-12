using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DrinkAndGo_2017
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();    //Renderizamos las excepciones en el ambiente de desarrollo
            app.UseStatusCodePages();           //Muestra la página html para mostrar el estatus de la excepción
            app.UseStaticFiles();               //Permite utilizar una página estática para mostrar errores
            app.UseMvcWithDefaultRoute();       //Permite agregar una ruta por default, sería contoller=Home action=Index id?
            
        }
    }
}
