﻿namespace DevOps.Primitives.SourceGraph.Helpers.Files
{
    internal static class AppveyorYmlContants
    {
        public const string CDorstNuGetAppveyorText
            = @"version: 1.0.{build}-{branch}
image: Visual Studio 2017
environment:
  LOCAL_NUGET_SOURCE_PATH: C:\projects
before_build:
- cmd: dotnet restore
build:
  verbosity: minimal
artifacts:
- path: '**\*.nupkg'
deploy:
- provider: Environment
  name: CDorstNuGet
  on:
    branch: master
notifications:
- provider: Email
  to:
  - chris@dorst.email
  on_build_success: true
  on_build_failure: true
  on_build_status_changed: false";

        public const string DotNetAppveyorText
            = @"version: 1.0.{build}-{branch}
image: Visual Studio 2017
before_build:
- cmd: dotnet restore
build:
  verbosity: minimal";
    }
}
