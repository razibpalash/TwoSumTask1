# TwoSum Solution

🚀 **Project Overview**

The TwoSum Solution project is a simple .NET 8.0 console application that finds two numbers in a list that add up to a specified target value. The project also includes unit tests using xUnit to ensure the correctness of the implementation.

---

🛠️ **Technologies Used**

* .NET 8.0
* xUnit (for unit testing)
* C#

---

⚙️ **Getting Started**

### Prerequisites

* .NET SDK 8.0

### Installation

1. Clone the repository:

   ```bash
   https://github.com/razibpalash/TwoSumTask1.git
   cd TwoSum
   ```

2. Restore packages:

   ```bash
   dotnet restore
   ```

3. Run the application:

   ```bash
   dotnet run --project TwoSum
   ```

4. Run the unit tests:

   ```bash
   dotnet test --logger "console;verbosity=detailed"
   ```

---

🧪 **Unit Testing**

Unit tests are performed using xUnit. The following test cases are covered:

1. **NormalReturns**: Verifies correct indices for valid input.
2. **DuplicateReturn**: Handles cases where duplicate numbers can sum to the target.
3. **NoSolutionReturn**: Checks if the function correctly returns when no solution exists.
4. **EdgeReturn**: Tests edge cases like empty arrays or a single element.

### Test Results

```
Test Run Successful.
Total tests: 4
     Passed: 4
 Total time: 1.7 Seconds
```
