using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_POS.Configurations
{
    internal class ConfigurationLoader
    {
        public IConfiguration Configuration { get; }
        public ConfigurationLoader()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath("C:\\Users\\Arriane Gonzales\\source\\repos\\Orange_POS\\Configurations")
                .AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true)
                .Build();
        }
    }
}
