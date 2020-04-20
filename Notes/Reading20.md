# Identity

- Identity can be configured using a SQL server and store a username, passwords, and profile data. 
- `AddDefaultIdentity` 
    - `AddIdentity`, `AddDefaultUI`, `AddDefaultTokenProviders` 
To create a Web app with authentication
```
Select File > New > Project.
Select ASP.NET Core Web Application. Name the project WebApp1 to have the same namespace as the project download. Click OK.
Select an ASP.NET Core Web Application, then select Change Authentication.
Select Individual User Accounts and click OK.
```
- `app.UseAuthentication();` is a way to enable the identity
- When the login page is submitted, the OnPostAsync action is called, `passwordSignInAsync` is called `_signInManager`
- Log out link invokes the `LogoutModel.OnPost`
- signout async clears the user
- Default web project templates allow anonymous access to the homepage.
```cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp1.Pages
{
    [Authorize]
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
```