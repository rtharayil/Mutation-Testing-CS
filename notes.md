




### **Step 1: Install Stryker as a Global Tool**
```sh
dotnet tool install -g dotnet-stryker
```
This installs Stryker globally so you can run it from anywhere.

### **Step 2: Verify Installation**
Check if Stryker is installed correctly by running:
```sh
dotnet tool list -g
```
Look for `dotnet-stryker` in the list. If it's not there, try installing it again.

### **Step 3: Run Stryker**
Navigate to your test project folder:
```sh
cd MutationTestingExample.Tests
dotnet stryker
```
This will execute mutation testing.

### **Alternative: Run Stryker Without Global Installation**
If you don't want to install it globally, you can install it as a local tool inside your test project:
```sh
cd MutationTestingExample.Tests
dotnet new tool-manifest
dotnet tool install dotnet-stryker
dotnet stryker
```

-----

### **Step 1: Create a Console Application**
```sh
dotnet new console -n MutationTestingExample
cd MutationTestingExample
```

### **Step 2: Create a Unit Test Project**
```sh
dotnet new xunit -n MutationTestingExample.Tests
```
Link the test project to the main project:  
```sh
cd MutationTestingExample.Tests
dotnet add reference ../MutationTestingExample/MutationTestingExample.csproj
cd ..
```

### **Step 3: Install Stryker for Mutation Testing**
```sh
cd MutationTestingExample.Tests
dotnet add package StrykerMutator.DotNetCoreCli
cd ..
```

### **Step 4: Add a Sample Function in `MutationTestingExample`**
Edit `Program.cs` inside `MutationTestingExample`:
```csharp
namespace MutationTestingExample;

public class Calculator
{
    public int Add(int a, int b) => a + b;
}
```

### **Step 5: Add a Unit Test in `MutationTestingExample.Tests`**
Create a new file `CalculatorTests.cs` inside `MutationTestingExample.Tests`:
```csharp
using Xunit;
using MutationTestingExample;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnSum_WhenGivenTwoNumbers()
    {
        var calculator = new Calculator();
        int result = calculator.Add(2, 3);
        Assert.Equal(5, result);
    }
}
```

### **Step 6: Run Unit Tests**
```sh
cd MutationTestingExample.Tests
dotnet test
cd ..
```

### **Step 7: Run Stryker Mutation Testing**
```sh
cd MutationTestingExample.Tests
dotnet stryker
```
This will mutate the code and analyze test effectiveness.  

