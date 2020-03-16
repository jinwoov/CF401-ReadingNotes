# Unit Testing and Documentation

Use WHY, WHAT, HOW structure
## Why ?
Unit Testing is used for developer to test their code snippet. It's primarily used for single code snippet. 


## What ?
Unit Testing is a great tool for developer to check their code if its working or not. In a C#, unit testing tests method in isolation.

## How?
In C#, 
1. Right click the solution to add a project
2. Choose `Unit Test Project Template`
3. Select `Test`
4. Then after that put testing code snippet
ie. 
```
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var calculator = new Calculator();

        int result = calculator.Add(4, 3);

        Assert.AreEqual(7, result);
    }
}
```
5. One thing to watchout for is that you don't want to erase whats in the square bracket otherwise, console will skip the testing code snippet.

`Assert` is unitTesting namespace that is provided by Microsoft.