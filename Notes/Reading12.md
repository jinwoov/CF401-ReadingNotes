# ASP.NET MVC

- ASP.net is MVC framework that is lieghtweight and open source framework that use ASP.NET core
- MVC consists of three models, 
    - model: use view model instance from the model
    - view: minimal logic within the views, if great deals of logic is needed, use view component view model or view template controller. It handles user interaction, work with the model and ultimately.
    - controller: handles user interaction, work with the model and ultimately
        - controller shouldn't be overly complicated with too many responsibilities
- ASP.Net core's routing is a powerful URL mapping component that let you build application that are comprehensive and searchable URLs.
- Few cool tricks that you can do terminal is that
```
dotnet --help : gives you an option of what you can type in following dotnet
dotnet new web -o mywebapp : will create a pre built  ASP application

the html that ASP use is cshtml that is called razor html
```
- @page has to be added on top of the page before its funtional html
- When you are injecting simple c# variables you can use `@` to indicate that subsequent statement is a code.
- `app.use.MVC()` is invoked to use MVC framework before tht you need to add `services.AddMVC()`.
- There is more command to add database query to the cshtml as well.