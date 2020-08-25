using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System.Collections.Generic;
using System.Net;

namespace Base.Serverless.Api.Handlers
{
    class FunctionExample : Functions
    {
        public FunctionExample() : base() { }

        public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
        {
            context.Logger.LogLine("Request incoming - get");
            return new APIGatewayProxyResponse()
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = "ok",
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
        }
    }
}
