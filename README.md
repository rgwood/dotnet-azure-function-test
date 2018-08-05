A small project to test out C# Azure Functions using .NET Core.

Created using the Azure Functions VS Code extension. Mostly using instructions from [here](https://code.visualstudio.com/tutorials/functions-extension/getting-started) and [here](http://codebuckets.com/2017/11/20/multiple-projects-with-net-core-and-visual-studio-code/).

#### How to create the solution and projects

First use the Azure Functions VS Code extension's Create New Project command to create a new C# project in a new subfolderfolder called `functions-project`.

```
dotnet new mstest -o test-project
cd test-project
dotnet add reference ../functions-project/functions-project.csproj
cd ..

dotnet new sln -n dotnet-azure-function-test

dotnet sln add functions-project/functions-project.csproj
dotnet sln add test-project/test-project.csproj
```

#### How to deploy

Use the Deploy to Function App command and tell it to use the directory at `functions-project/bin/Release/netstandard2.0/publish` (if this doesn't exist already, you may need to run `dotnet publish`).

This is a fairly manual process. Next up, I'd like to look into [continuous deployment](https://docs.microsoft.com/en-us/azure/azure-functions/functions-continuous-deployment).

#### How to install NuGet Dependencies
`dotnet add package Newtonsoft.Json`

#### Tests
`dotnet test`

Note that there is a bug (?) in the current version of .NET Core that means when you run `dotnet test` on a solution, it attempts to run tests in _all_ projects (and fails on projects that contain no tests). I'm using [this handy fix by Martin Ullrich ](https://dasmulli.blog/2018/01/20/make-dotnet-test-work-on-solution-files/), as found in [this GitHub issue](https://github.com/Microsoft/vstest/issues/1129).
