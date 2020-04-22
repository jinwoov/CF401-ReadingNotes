- seed the data
- testing
1. add test project
2. xunit
3. add dependency
    - Test the getter and setter
    - crud operation
4. Give title to the method
```cs
[Fact]
public void CanAddTitle()
{
    Post post = new Post();
    post.title = "title"

    Assert.Equal("the beginning of the end!", post title)
}

[Fact]
public void CanChangePostContent()
{
    Post post = new Post()
    {
        title = "Bla",
        content = "loren"
    }

    Assert.Equal("loren", post.content)
}

[Fact]
public async Task CanAddPostToDB()
{
    // Arrange (bring in the core and data) for useinmemoryDb(install-package microsoft.entityFrameworkcore.inmemory -version 3.1.3)
    DbContextOptions<dbcontextNAME> options = new DbContextOptionsBuilder<DbContextName>()
        .UseInMemoryDataBase("CanAddPostToDb")
        .Options;
    
    /// name of the 
    using(dbContext context = new dbcontext(options))
    {
        PostService ps = new PostService(context);

        Post post = new Post()
        {
            Title = ""
            Content = "bla"
        }
        // for second method create a variable
        var result = await ps.CreatePostAsync(post);

        // check if the post exists through the context directly
        var data = context.Posts.Find(post.ID);

        Assert.Equal(post, data);
        // change our service to have a return and check the data that came back

        //have to change service to have return post
        return post

        Assert.Equal("",result.Title);


    }

}
```


TO add Razor page

1. first enable razor
```cs

public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();
    // another way services.AddRazorPages(); default to mvc and razor


}

```
2. Add `pages` folder to create a razor pages

<!-- If we  wanted /account/register.html-->
with razor pages we ge o modify our routes through folders

3. create a folder name inside of `pages`, name it to how you want it to route
4. `Razor Page` - Register.cshtml ( if you want last route to be register)
5. need page directive 
6. register page is very important

info register 
```cs
@page
@model //where the model is where the model is you can click on where the model is 
@{
    ViewData["Title"] = "Login";
}
@*We need to ask for user info*@

@*Create our form*@

<form method="post">
    <div asp-validation-summary="All"></div>
    </hr>
<label asp-for="RegisterData.Email"></label>
<input asp-for="RegisterData.Email" />
<span asp-validation-for="RegisterData.Email"> </span>

<label asp-for="RegisterData.Firstname"></label>
<input asp-for="RegisterData.Firstname" />
<span asp-validation-for="RegisterData.Firstname"> </span>

<label asp-for="RegisterData.Lastname"></label>
<input asp-for="RegisterData.Lastname" />
<span asp-validation-for="RegisterData.Lastname"> </span>

<label asp-for="RegisterData.Birthday"></label>
<input asp-for="RegisterData.Birthday" />
<span asp-validation-for="RegisterData.Birthday"> </span>

<label asp-for="RegisterData.Password"></label>
<input asp-for="RegisterData.Password" />
<span asp-validation-for="RegisterData.Password"> </span>

<label asp-for="RegisterData.ConfirmPassword"></label>
<input asp-for="RegisterData.ConfirmPassword" />
<span asp-validation-for="RegisterData.ConfirmPassword"> </span>

<button type="submit">Regiser </button>
</form>
```

- uncollapse the file and it will show .cshtml.cs which will show the behind the scene
- Code behind: which runs behind the razor page (PageModel)
- doesn't need to create a cshtml.cs file
- route for page is same as how you setup in folder
- model for cshtml.cs is like DTO
in cshtml.cs
- [RegularExpression]
-add tag helper at the root of `pages` folder
```cs
[BindProperty]
public RegisterInput RegisterData {get; set;}
    _userManager = userManager
public UserManager<ApplicationUser> _userManager
public SignInManager<App>

public RegisterModel (UserManager<ApplicationUser> usermanager, SignInManager<AplicationUser> signingManager)// bring library aspnetcore identity
{
    _userManager = userManager;
    _signingManager = signingManager;
}

public void OnGet()
{

}

public async Task<IActionResult> void OnPost()
{
    if(ModelState.IsValid)
    {
        var user = new ApplicationUser()
        {
            userName = RegisterData.Email,
            Email = RegisterData.Email,
            FirstName = RegisterData.Firstname,
            LastName = RegisterData.LastName,
            Birthdate = RegisterData.Birthday
        };

        // create the account using Identity 

        var result = await _userManager.CreateAsync(user, RegisterData.Password);

        if(result.Succeeded)
        {
            //sign the user in
            await _signingManager.SignInAsync(user, isPersistent: false);
            return RedirectToAction("Index", "Home");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(String.Empty, error.Description);
        }
    }
    
    return Page();
}

// nest this class
public class RegisterInput
{
    [Required]// use data annotation // this is the frontend authenticate model
    [EmailAddress] 
    [Display(name = "Email Address")]
    public string Email{get;set;}

    [Required]
    [Display(name = "First name")]
    public string FirstName {get;set;}

    [Required]
    [Display(name = "Last name")]
    public string Lastname {get;set;}

    [Required]
    [DataType(DataType.Date)]
    public DateTime Birthday {get;set;}

    [Required]
    [StringLength(100, ErrorMessage = "The {password0} must be at least {2} and max of {1} characters long", MinimumLength = 8)]
    [DataType(DataType.Password)]
    public string Password {get;set;}

    [Required]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMssage= "Doesnot match")]
    public string ConfirmPassword {get;set;}



}

```
In startup
```cs

    endpoints.MapRazorPages();
    endpoins.MapControllerRoute("default", "{controller=Home}/{action=}/{id?}")
```