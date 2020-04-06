# Dependency injection
- DI for short
- `MyDependency` class with a `writeMessage` method that other classes in an app depend upon
- The dependency injection is used as an interface or base class to abstract the dependency implementation
- The collection of dependencies that must be resolved is typically referred to as a dependency tree, dependency graph or object graph.
- Example of adding interface dependency 
```
services.AddScoped<IMyDependency, MyDependency>();
```
- Only these three can be implemented to startup constructor
    - IWebHostEnvironment
    - IHostEnvironment
    - IConfiguration

- `startup.Configurationservices` method is responsible for defining the services that app uses

## Repository pattern
- Repositories are classes or components that captures the logic required to access data sources
- For each aggregate, we should create a repository class. This microservice based on Domain-Driven Design(DDD) patterns, the only channel you should use to update the database should be the repositories. 
- One should define one repository for each aggregate root. This is to achieve the goal of the aggregate root to maintain transactional consistency between all oth objects within the aggregate.

## Repository pattern part 2
- abstract of data layer and second it is a way of centralizing the handling of the domain objects
- DAO: Data access object 

## SOLID
- Single Responsibility principle(SRP) is every method should have only one responsibility.
- Open/ Close principle is concept of encapsulation and inheritance. 