using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationStudy.Contexts;
using WebApplicationStudy.Data;

namespace WebApplicationStudy
{
  public class Startup
  {
    public IConfiguration Configuration { get;}

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      //make models available dependency injection
      services.AddDbContext<TeacherContext>(options => options.UseInMemoryDatabase("TeacherDB"));
      services.AddDbContext<StudentContext>(options => options.UseInMemoryDatabase("StudentsDB"));
      services.AddDbContext<ToDoContext>(options => options.UseInMemoryDatabase("foo"));//make 'toDo' aailable 
      services.AddMvc()
        .AddXmlDataContractSerializerFormatters();// change it to jsonDataContr??
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseMvc();

      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("MVC didn't find anything.");
      });
    }
  }
}