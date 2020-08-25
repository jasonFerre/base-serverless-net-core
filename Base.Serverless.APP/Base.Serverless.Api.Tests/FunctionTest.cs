
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.TestUtilities;
using Base.Serverless.Api;
using Xunit;

namespace Base.Serverless.Tests
{
    public class FunctionTest
    {
        public FunctionTest()
        {
        }

        [Fact]
        public void TetGetMethod()
        {
            TestLambdaContext context;
            APIGatewayProxyRequest request;
            APIGatewayProxyResponse response;

            Functions functions = new Functions();


            //request = new APIGatewayProxyRequest();
            //context = new TestLambdaContext();
            //response = functions.Get(request, context);
            //Assert.Equal(200, response.StatusCode);
            //Assert.Equal("Hello AWS Serverless", response.Body);
        }
    }
}
