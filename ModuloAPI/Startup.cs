namespace ModuloAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {

        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollections service)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHost env)
        {
            if(env.UserDeveloperExceptionPage())
            {
                app.UseDeveloperExceptionPage();
                app.useSwagger();
                app.UseSwaggerUI( c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ModuloAPI v1"));

            }

            app.UseHttpsRedirection();
            app.UseRouting();
            // app.UseAuthorization();
            app.Endpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}