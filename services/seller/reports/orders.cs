using System.Collections.Generic;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using BoostUtils;
using FikaAmazonAPI.Utils;
using System;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
// [assembly: LambdaSerializer(
// typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace BoostReports
{
    public class Orders
    {
        public APIGatewayProxyResponse GetOrders(APIGatewayProxyRequest request, ILambdaContext context)
        {
            APIGatewayProxyResponse response;
            Dictionary<string, string> dict = new Dictionary<string, string>();
            
            var orders = AWS.Auth.amazonConnection.Orders.GetOrders
            (
                new FikaAmazonAPI.Parameter.Order.ParameterOrderList
                {
                    TestCase = Constants.TestCase200
                }
            );
            dict.Add("Orders", orders.ToJson());
            response = ResponseHandler.CreateResponse(dict);
            Console.WriteLine(orders);
            return response;
        }
    }
}
