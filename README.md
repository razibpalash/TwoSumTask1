# TwoSum Solution

🚀 **Project Overview**

The TwoSum Solution project is a simple .NET 8.0 console application that finds two numbers in a list that add up to a specified target value. The project also includes unit tests using xUnit to ensure the correctness of the implementation.

---

🛠️ **Technologies Used**

* .NET 8.0
* xUnit (for unit testing)
* C#

# **Proof of Work**

PS C:\Users\razib\source\repos\TwoSumSolution> dotnet test --logger "console;verbosity=detailed"
Restore complete (1.0s)
  TwoSum succeeded (0.4s) → TwoSum\bin\Debug\net9.0\TwoSum.dll
  TwoSumTest.Tests succeeded (0.2s) → TwoSumTest.Tests\bin\Debug\net9.0\TwoSumTest.Tests.dll
A total of 1 test files matched the specified pattern.
C:\Users\razib\source\repos\TwoSumSolution\TwoSumTest.Tests\bin\Debug\net9.0\TwoSumTest.Tests.dll
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.5)
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.5)
[xUnit.net 00:00:00.14]   Discovering: TwoSumTest.Tests
[xUnit.net 00:00:00.14]   Discovering: TwoSumTest.Tests
[xUnit.net 00:00:00.20]   Discovered:  TwoSumTest.Tests
[xUnit.net 00:00:00.20]   Discovered:  TwoSumTest.Tests
[xUnit.net 00:00:00.21]   Starting:    TwoSumTest.Tests
[xUnit.net 00:00:00.21]   Starting:    TwoSumTest.Tests
[xUnit.net 00:00:00.32]   Finished:    TwoSumTest.Tests
[xUnit.net 00:00:00.32]   Finished:    TwoSumTest.Tests
  Passed TwoSumTest.Tests.UnitTest.DuplicateReturn [9 ms]
  Passed TwoSumTest.Tests.UnitTest.NoSolutionReturn [< 1 ms]
  Passed TwoSumTest.Tests.UnitTest.EdgeReturn [1 ms]
  Passed TwoSumTest.Tests.UnitTest.NormalReturns [< 1 ms]

Test Run Successful.
Total tests: 4
     Passed: 4
 Total time: 1.2370 Seconds
  TwoSumTest.Tests test succeeded (1.7s)

Test summary: total: 4, failed: 0, succeeded: 4, skipped: 0, duration: 1.7s
Build succeeded in 4.0s
