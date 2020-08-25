using Amazon.Lambda.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Base.Serverless.Api
{
    public class Functions
    {
        private IServiceCollection _serviceCollection;
        protected IServiceProvider _serviceProvider;
        public IConfiguration _configuration;

        /// <summary>
        /// Default constructor that Lambda will invoke.
        /// </summary>
        public Functions()
        {
            Configure();
            Services();
        }

        private void Configure()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json");

            _configuration = builder.Build();
        }

        private void Services()
        {
            if (_serviceCollection == null)
                _serviceCollection = new ServiceCollection();
            else
                return;

            //aws services
            _serviceCollection.AddDefaultAWSOptions(_configuration.GetAWSOptions());
            
            //example how to inject aws service
            //_serviceCollection.AddAWSService<IAmazonS3>();

            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }
    }
}
