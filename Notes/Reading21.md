# Razor page
- to enable razor page, add
```cs
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseMvc();
    }
}
```

`@page` indicates that it is razor page
- this makes MVC action which means it handles request directly, without going through the controller.
- `@page` has to be the first directive on the page 
- Page model class has .cs appended such as `Pages/Index2.cshtml.cs.`
- `OnPostAsync` handler method is to run `POST` request.
    - `OnGet` to initialize state needed for the page. OnGet sample.
    - `OnPost` to handle form submissions.
- `[BindProperty]`  Binding to properties can reduce the amount of code you have to write. Binding reduces code by using the same property to render form fields.
- By putting @page "{id:int}", it allows browser to accept request page to contain `int`, to make it optional you can add `?`
- `OnPostDeleteAsync`
    - accepts the `id` as query string and if page contains {id:int}, that allows route data. 
- `[required]` field can be used to require user to put the input
## MVC vs Razor Page
- MVC
 1. request from home
 2. ASP.NET routes
 3. Controller
 4. ASP.NET view Engine
 5. Render View
- Razor Pages
 1. Request from home
 2. ASP.NET routing
 3. Razor page
 4. Asp.NET view
 5. Render view

- Razor page works as controller action.
- Example of get and post
```cs
public class ContactModel : PageModel
{
    public void OnGet()
    {
        // logic here...
        // calls to services etc.
    }

    public void OnPost()
    {

    }
}
```

the properties can be float on top of csfile
