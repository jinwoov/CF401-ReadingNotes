account folder 

1. pick razor page `Login`
2. Login view model with class
3. need view model folder

IN VIEWMODEL/LoginViewModel
```cs

[Required]
[DataTye(DataType.EmailAddress)]
public string Email {get;set;}

[Required]
[DataType(DataType.Password)]
public string Password {get;set;}

```

in account folder login.csthml.cs
```cs
[BindProperty]
public LoginViewModel Input{get;set;}

public LoginModel(SignInManager<ApplicationUser> signManager)
{
    _signManager = signManager
}

public void OnGet()
{
    
}

public async Task<IActionResult> OnPost()
{
    if (ModelState.IsValid)
    {
        var result = await _signManager.PasswordSignAsync(Input.Email, Input.Password, isPerSistent: false, false);

        if(result.succeeded)
        {
            
            return RedirectToAction("Index", "Home");
        }
        else
        {
            ModelState.AddModelError("", "Invalid Login Attempt");
            return Page();
        }
    }
}

```

In cshtml
```cs
<form method="post">
    <label asp-for="Input.Email"></label>
    <input asp-for="Input.Email" />
    <span asp-validation-for="Input.Email"></span>

    <label asp-for="Input.Password"></label>
    <input asp-for="Input.Password" />
    <span asp-validation-for="Input.Password"></span>

    <button type="submit">Login</button>
</form>
```



views/In shared folder
- add layout
- view injection
```cs
@using Microsoft.AspNetCore.Identity;
@using CMSD10DemoCode.Models;
@inect UserManger<ApplicationUser> UserManager;
@inject SigninManager<ApplicationUser> SignInManager;

//above doc


//in body

@if (SignInManager.IsSignedIn(user))
{
    <span> WELCOME @User.Claims.First(x => x.Type = "FullName").Value!</span>
    <form asp-page="/Account/Logout">
    <button type="submit">Logout</button>
    </form>


}

@else
{
    <a asp-page="/Account/Login"> Login </a>

    <a asp-page="/Account/Register"> Register </a>
}
above @renderpage
```


Create a razor page in the /Account folder
Logout.cshtml
```cs



```

```cs //in model

private SignInManager<ApplicationUser> _signInManager;

public LogoutModel(SignInManager<ApplicationUser> signInManager)
{
    _signInManager = signInManager
}

public void OnGet()
{

}

public async Task<IActionResult> OnPost()
{
    await _signInManager.SignOutAsync();
    return (RedirectToAction("Index", "Home"))
}

```