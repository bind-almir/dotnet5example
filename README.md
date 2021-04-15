**Instructions**

This repository contains dockerized dotnet5 application that will run behind the Lambda function. Following instructions contain steps to reproduce creating a project from scratch. If you don't want to do that, but to use what is already built instead, then move to the deployment section.

**Start project from scratch**

1. Install dotnet 5

      https://docs.microsoft.com/en-us/dotnet/core/install/linux
      
      https://docs.microsoft.com/en-us/dotnet/core/install/macos

      https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net50

      

2. Start new project 



      `mkdir dotnet5example`

      `cd dotnet5example` 

      `dotnet new -i Amazon.Lambda.Templates`

      `dotnet new lambda.image.EmptyFunction`

      `dotnet add ./src/dotnet5example/dotnet5example.csproj`

      `dotnet add test/dotnet5example.Tests/dotnet5example.Tests.csproj`

      `git init`

      `dotnet new gitignore`

3. Update lambda code then update request in the 6th step accordingly

4. Build

      `dotnet lambda package --configuration Release`

5. Run image locally

      `docker run -p 9000:8080 dotnet5example:latest`

6. Test 

      `curl -XPOST "http://localhost:9000/2015-03-31/functions/function/invocations" -d '{"key1": "value1", "key2": "value2", "key3": "value3"  }'`


7. Login to AWS ECR (change region)

      `aws ecr get-login-password --region <region> | docker login --username AWS --password-stdin <region>.dkr.ecr.<region>.amazonaws.com`

8. Create container registry

      `aws ecr create-repository --repository-name dotnet5example --image-scanning-configuration scanOnPush=true` 

9. Push the image to the registry (change region and account number)

      `docker push <region>.dkr.ecr.<region>.amazonaws.com/dotnet5example:latest`

10. Deploy

      ``
