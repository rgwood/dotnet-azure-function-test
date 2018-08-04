A small project to test out C# Azure Functions using .NET Core.

Created using the Azure Functions VS Code extension. Mostly using instructions from [here](https://code.visualstudio.com/tutorials/functions-extension/getting-started).

#### How to installNuGet Dependencies
`dotnet add package Newtonsoft.Json`

#### Tests
`dotnet test`

Note that there is a bug (?) in the current version of .NET Core that means when you run `dotnet test` on a solution, it attempts to run tests in _all_ projects (and fails on projects that contain no tests). I'm using [this handy fix by Martin Ullrich ](https://dasmulli.blog/2018/01/20/make-dotnet-test-work-on-solution-files/), as found in [this GitHub issue](https://github.com/Microsoft/vstest/issues/1129).