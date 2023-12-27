public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRazorPages();
        services.Configure<RouteOptions>((routeoptions)=>
        {
            routeoptions.LowercaseUrls = true;
        });

    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

        app.UseRouting();
        app.UseEndpoints((endpoints)=>
        {
            endpoints.MapGet("/", async (context)=>
            {
                await context.Response.WriteAsync("Trang chu");
            });
            endpoints.MapGet("/abc.html", async (context)=>
            {
                await context.Response.WriteAsync("Trang gioi thieu");
            });
            endpoints.MapRazorPages();
        });

    }
}