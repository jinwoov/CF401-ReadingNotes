# View Components

- dont use model binding and only depends on the dta provided when calling into it.
- also works with razor pages
- render chunk rather tha na whole response
- invoked from layout page
- consists of two part: the class and result.
- view components class can be drived using ` viewcomponent` attribute. 
- must be public and not nested and non abstract classes
- fully supports constructor dependency injection
- it defines `invokeasync` method that reutrns a `Task<IViewComponentResult>` or synchronous `invoke` method.
- not reachable directly as an HTTP endpoint.
- to customize view search path

```cs
services.AddMvc()
    .AddRazorOptions(options =>
    {
        options.ViewLocationFormats.Add("/{0}.cshtml");
    })
    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
```

- in here first {0} is Components/{View Component Name}/{View Name}.
- view components can be invoked asynchronously 
- view component can be invoked as a Tag helper
- using `<vc>` tag to call view component
- you can inherit `viewcomponent` into a class.
    - in that you can create a method that returns `IViewcomponentResult` which then returns Content(with navigation)
- In Razor view you can use `@Component` tag to invoke a method to view components 
- ViewModel can be added to the razor page by adding a ItemViewModel and i nthat you can bringing in the library.