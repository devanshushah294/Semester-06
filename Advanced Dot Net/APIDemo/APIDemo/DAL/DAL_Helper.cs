using Microsoft.AspNetCore.Connections;

namespace APIDemo.DAL
{
    public class DAL_Helper
    {
        public static string connStr = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("myConnectionString");
    }
}
