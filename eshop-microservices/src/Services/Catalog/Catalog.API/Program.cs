namespace Catalog.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            WebApplication app = builder.Build();



            app.Run();
        }
    }
}
