using Microsoft.EntityFrameworkCore;
using PhoneStore.DAL.Context;

namespace PhoneStore.API.Extension
{
    public static class Connection
    {
        public static void AddConnection(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddDbContext<AppDbContext>(dpOption =>
            {
                var ConnectionString = builder.Configuration.GetSection("ConnectionStrings")["ConnString"];
                dpOption.UseSqlServer(ConnectionString);
            });
        }
    }
}
 