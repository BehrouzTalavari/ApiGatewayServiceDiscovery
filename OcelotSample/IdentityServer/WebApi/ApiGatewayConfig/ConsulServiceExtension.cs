using Consul;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System;

namespace IdentityServerWebApi.ApiGatewayConfig
{
    public static class ConsulServiceExtension
    {
        public static IServiceCollection AddConsulConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConsulClient, ConsulClient>(p => new ConsulClient(consulConfig =>
            {
                //consul address  
                var address = configuration["ConsulConfig:ConsulAddress"];
                consulConfig.Address = new Uri(address);
            }, null, handlerOverride =>
            {
                //disable proxy of httpclienthandler  
                handlerOverride.Proxy = null;
                handlerOverride.UseProxy = false;
            }));
            return services;
        }

        public static IApplicationBuilder UseConsul(this IApplicationBuilder app, IConfiguration configuration)
        {
            var consulClient = app.ApplicationServices.GetRequiredService<IConsulClient>();
            var logger = app.ApplicationServices.GetRequiredService<ILoggerFactory>().CreateLogger("AppExtensions");
            var lifetime = app.ApplicationServices.GetRequiredService<IHostApplicationLifetime>();

            if (app.Properties["server.Features"] is not FeatureCollection features)
            {
                return app;
            }

            //var servicePort = int.Parse(configuration.GetValue<string>("ConsulConfig:ServicePort"));
            //var serviceIp = "127.0.0.1";// Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
            //var serviceName = configuration.GetValue<string>("ConsulConfig:ServiceName");
            //var serviceId = configuration.GetValue<string>("ConsulConfig:ServiceId");

            var registration = new AgentServiceRegistration()
            {
                ID = configuration["ConsulConfig:ServiceId"],
                Name = configuration["ConsulConfig:ServiceName"],
                Address = configuration["ConsulConfig:ServiceHost"],
                Port = int.Parse(configuration["ConsulConfig:ServicePort"]),
            };

            logger.LogInformation("Registering with Consul");
            consulClient.Agent.ServiceDeregister(registration.ID).ConfigureAwait(true);
            consulClient.Agent.ServiceRegister(registration).ConfigureAwait(true);

            lifetime.ApplicationStopping.Register(() =>
            {
                logger.LogInformation("Unregistering from Consul");
                consulClient.Agent.ServiceDeregister(registration.ID).ConfigureAwait(true);
            });

            return app;
        }
    }
}
