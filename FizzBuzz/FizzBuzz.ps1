$ProjectDir = "."
$PackagesDir = "$ProjectDir\packages"
$OutDir = "$ProjectDir\FizzBuzz.Tests\bin\Debug"

# Install NUnit Test Runner
$nuget = "$ProjectDir\.nuget\nuget.exe"
& $nuget install NUnit.Runners -ExcludeVersion -o $PackagesDir

# Set nunit path test runner
$nunit = "$ProjectDir\packages\NUnit.ConsoleRunner\tools\nunit3-console.exe"

#Find tests in OutDir
$tests = (Get-ChildItem $OutDir -Recurse -Include *Tests.dll)

# Run NUnit3 tests
& $nunit $tests --noheader --framework=net-4.5 --work=$OutDir