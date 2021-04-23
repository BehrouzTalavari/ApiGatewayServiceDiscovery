using System;
using System.Runtime.Serialization;

namespace WebApplication.Ocelot.Models
{
    public class ConfigurationSetting
    {
        public int ServicePort { get; set; } = 8585;
        public string ServiceName { get; set; }="forcast";
        public string ServiceHost { get; set; } = "localhost";
        public string ConsulAddress { get; set; } = "http://127.0.0.1:8500";
    }
}