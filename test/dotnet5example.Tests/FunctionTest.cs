using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using dotnet5example;

namespace dotnet5example.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {

            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var context = new TestLambdaContext();
            Request request = new Request();
            request.Key1 = "hello"; 
            var response = function.FunctionHandler(request, context);

            Assert.Equal("hi", response);
        }
    }
}
