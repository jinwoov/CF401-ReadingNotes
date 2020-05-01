

ServiceProvider is like a police where it runs the whole dependent 

- traffic cop

Admin/Dashboard.cshtml

Add new controller using mvc entity framework


```cs
public ProductController(database context)
{
    _context = context;

}


public async Task<IActionResult> Index()
{
    await _context.Posts.ToListAsync();
    return view(posts);

}


```

create a folder call posts
- new item in the view razor view

```html
<h3>title
p

<form method="post">
<label @asp-for="Title">
<input type=text value=@Model.title>


<button asp-route-method="update" asp-route-productID="@Model.ID">Update</button>
</form>

```

-> admin/dashboard -> product -> create -> update/delete 
cshtml.cs


```cs

[BindProperty]
public Product UserProduct {get;set;}


public Task<IActionResult> Onpost( int productID)
{
    


}
```

oopost(int productid)