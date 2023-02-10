using System.Collections.Generic;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using BoostUtils;
using FikaAmazonAPI;
using FikaAmazonAPI.Utils;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
// [assembly: LambdaSerializer(
// typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AWS
{
    public class Auth
    {
        public static AmazonConnection amazonConnection = new AmazonConnection(new AmazonCredential()
        {
            AccessKey = "AKIATUQPFEPKGOJPDUJH",
            SecretKey = "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",
            RoleArn = "arn:aws:iam::250213639124:role/SpApiRole",
            ClientId = "amzn1.application-oa2-client.79b4547c6b494b8ea0a2ad418f6137c5",
            ClientSecret = "d3c9ac7ae0516d1f57b35751ea230e8801c19c155ebb469c7fa1a66b9acda60f",
            RefreshToken = "Atzr|IwEBIA4O3MC3zkv5_-O2LAXIRQE0ABz9Msmg9YyyfZf4b5Wd4lXov1z06IRlib3TKYMP9jDKkoV0JjyI9u09aEqrXdQs9SgXSQw0GnqCIGn_FUOVdgfNqy2vqau9TO_IJBma4rUvPuQUa1jANZJ3ofVFjtmbutces_K_rhknBgZJ-UT5VTDoQjGZhmx3bKr_pInGODDDIcT9wYBeLysbD8CSTsWTL1-_YrPW8A_G7AxuSQIwJx_GeLsjZoln9bmXM9IvzT5sUiXCL-BCI1RBJizIR5DFkVbhqkyZvHzJQSzeZF-pqd6pj4uQJy2G1BJKCZnIXd8",
            MarketPlace = MarketPlace.Brazil, //MarketPlace.GetMarketPlaceByID("A2VIGQ35RCS4UG")
            Environment = Constants.Environments.Sandbox
        });
    }
}
