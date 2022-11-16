namespace Purspot.Personalkollen.Core.Api.Startup
{
    /// <summary>
    /// 
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Configures the swagger.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <returns></returns>
        public static WebApplication ConfigureSwagger(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            app.UseSwagger();
            app.UseSwaggerUI();
            //}

            return app;
        }
    }

}
