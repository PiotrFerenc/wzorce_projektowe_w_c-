using System;

namespace Singleton
{
    public class GlobalConfiguration
    {
        private  GlobalConfiguration()
        {
            
        }

        public string ConnectionString => "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

        private static GlobalConfiguration Configuration { set; get; }

        public static GlobalConfiguration GetInstance()
        {
            if (Configuration is null)
            {
                Configuration = new GlobalConfiguration();
            }

            return Configuration;
        }
    }
}