using Infrastructure.SqlDAL;

namespace CodeChallenge
{
    internal static class Setup
    {
        public static void AddDependencies(this IServiceCollection services,
                                           IConfiguration configuration)
        {
            RegisterDbContext(services);
        }

        private static void RegisterDbContext(IServiceCollection services)
        {
            services.AddScoped(sp =>
            {
                return new CodeChallengeDbContext("Server=localhost;Database=Local instance MySQL80;Uid=root;Pwd=XXXXXX;");
            });
        }
    }
}
