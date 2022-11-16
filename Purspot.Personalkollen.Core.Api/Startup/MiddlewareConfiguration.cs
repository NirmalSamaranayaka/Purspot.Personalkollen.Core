namespace Purspot.Personalkollen.Core.Api.Startup
{
    /// <summary>
    /// 
    /// </summary>
    public static class MiddlewareConfiguration
    {
        /// <summary>
        /// Configures the middeleware.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <returns></returns>
        public static WebApplication ConfigureMiddeleware(this WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }
    }
}
