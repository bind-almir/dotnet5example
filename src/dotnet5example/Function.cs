using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace dotnet5example
{

    public class Request
    {
      public string Key1 {get; set;}
    }
    public class Function
    {
        

        public string FunctionHandler(Request input, ILambdaContext context)
        {
            return "hi";
        }
    }

}
