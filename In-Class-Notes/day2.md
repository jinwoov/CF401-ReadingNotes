Try 
- "try" everything in a code snippet to see it works
- there is a chance that that bit of code will throw an exception
- activates the "catch"
- A, catch or finally or both must accompany it.



Catch
- catch "catches" the exception
- like an if..else statement
- we can have as many as we want
- Order matters
- general exception should be at the end
- most specific condition exception needs to be first
- Console.writeline
- throw

Finally
- will Always run if the code is able to run it
- disconnect/cleanup anything that is required
- i

Throw
- can be placed in a catch
- if that catch "couldn't take of it, it can throw it to the prior method.

#Region exceptionOverview to close the close 

///////// after noon

test are use so that strong enough to test out

TDD -test driven development

form of writing test first and code 2nd.

engineer - writes their own test and write their own code

red - test is failing
    - make the test pass
green - refactor

write the test first, you make the test pass and you make it fail

// Red - Red is not pasing the code is satisfactory
    // modify the code ==
        // you can modify the code to pass the test
        // turn hard coded values into variable
        // break out into other methods

// green - test is passing 
    - can be moved on 
    - refactor the test
    - write a new test


code coverage = percentage of codes that has been tested.

you need test from now on

.Net has 3 different types of testing frameworks
1. NUNIT
    - Core team unit
2. MSTEST
3. XUNIT - Brad Wilson
    - go .net framework
    - 

[Fact]
two types that you can write in XUNIT
- fact - One statement is used and will be true
- theory - might be 

test should be singular and never stack it

Fizz; divisible by 3
buzz: divisible by 5
fizzbuzz; divisible by both
