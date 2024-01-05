namespace Middleware.Settings;

public static class Configurations
{
    private static IConfiguration BuildConfiguration()
    {
        return new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddUserSecrets("61d71028-6014-4dc4-9e48-04652af5e08e")
            .Build();
    }

    public static ApiSettings ApiSetting
    {
        get
        {
            var _config = BuildConfiguration();

            return _config
                       .GetSection(ApiSettings.Section)
                       .Get<ApiSettings>() ??
                   throw new ArgumentException("Seção para configuração da API não encontrada!");
        }
    }
}