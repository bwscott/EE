Version = 5131d4298efd50f32952814c7ee85893054276db

This is a .NET implementation of the FizzBuzz exercise which prevents the use of Gradle build files

Each zip is distributed with a Visual Studio 2017 .sln file to allow viewing of the solution via Visual Studio.

The tests for each zip can be run without Visual Studio.

To run the tests

1) Extract the zip file to a directory
2) Download the Nuget.exe file from https://dist.nuget.org/win-x86-commandline/latest/nuget.exe and copy to the .nuget folder
3) Start powershell and navigate to the directory the files were extracted to
4) Run the FizzBuzz.ps1 powershell script

This script installs the NUnit Console runner and executes the solution tests, outputting the result to the console window
