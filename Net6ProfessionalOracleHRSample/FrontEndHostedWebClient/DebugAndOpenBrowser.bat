echo "Don't forget to do a shift alt d to open debugging in the browser. If you need to debug in Visual Studio, use the IIS Express debug profile."
start msedge --remote-debugging-port=9222 https://localhost:44398/
dotnet watch run --project XE_HR_FrontEndHostedWebClient.csproj --verbose
cmd /k
