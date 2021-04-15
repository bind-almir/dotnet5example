FROM public.ecr.aws/lambda/dotnet:5.0

WORKDIR /var/task

COPY "bin/Release/net5.0/linux-x64/publish"  .

CMD [ "Net5Example::dotnet5example.Function::FunctionHandler" ]
