internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.UseDefaultFiles();

        app.UseStaticFiles();

        app.MapGet("/health", () => 
        {
            return "Server OK!";
        });

        app.MapPost("/api/v1/todoes", () =>
        {
            return "Received a post request to '/api/v1/todoes'";
        });

        app.Run();
    }
}