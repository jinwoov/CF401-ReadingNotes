# view imports
- .net core speific
- reusuable
- service/database call/ api call
- partial are html and css
- take the partial and data injection
- 
create a components folder
- create a class
1. implement `ViewComponent` * most
2. `TopPostViewComponent` will implement the view component
3. `[ViewComponent]`

```cs
public class TopPosts : ViewComponent
{
    private readonly CMDbContext _context;

    public TopPosts(CMSDbContext context)
    {
        _context = context;
    }

    // required or reserved method name Invoke, InvokeAsync

    public async Task<IViewComponentResult> InvokeAsync(int number)
    {
        // make a call to my host and get the top latest three result
        var posts = await _context.Posts.OrderByDescending(x => x.ID)
                                       .Take(number);

        return View();
        
    }
}

```

in view folder -> shared -> Components -> name the folder as same as the viewcomponent class name (ie `TopPosts`)

- the name has to be view page of Default.cshtml

```cs
@model IEnumerable<name of the model ie CMS10DemoCode.Models.Post>

<h1>Top Posts</h1>

@foreach (var post in Model)
{
    <h2>@post.Title</h2>
    <p>@post.Content</p>
    <hr/>
}
```

-at the page you want to call

```cs

@await Component.InvokeAsync("TopPosts", 3) //has to match the class of viewcomponent injecting the 3

```