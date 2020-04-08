# Intro to APIs

- User secrets is a way for us to store a sensitive information such as API keys, client secrets and connection string from average joe user.
- User secrets aren't pushed to the open source and is kept like `.env` file.
```Json
  "myBingAPIKey": "{VALUE}",
  "textAPIKey": "{VALUE}"
  ```

- 400 is client error
- 500 is devloper error
- http request with ASP.Net core
- the server (kestrel) listens for requests
- To run the test method you can use `[TestClass]` that has `[TestMethod]` in it
- how to test is same as you have to arrange, act and assert
- you can create a API application by creating ASP.NET core application with API server
- To add the dabse you can use `:DbContext` to inherit database context
- add in `ConfigureService` 
```
services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
                
```
- there is option of adding API controller class
- You can test the get method using postman