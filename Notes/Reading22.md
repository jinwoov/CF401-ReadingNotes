# Claims
- Adding a claims checks
    - Claim authorization checks are declarative and developer put within their code.
    - In `Startup.cs` file,
        ```cs
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddAuthorization(options =>
            {
                /// this checks for employee number
                options.AddPolicy("EmployeeOnly", policy => policy.RequireClaim("EmployeeNumber"));
            });
        }

        //apply in the razor model
        [Authorize(Policy = "EmployeeOnly")]
        public IActionResult VacationBalance()
        {
            return View();
        }

        ```
    - `AuthorizeAttribute` can be applied to entire controller 
    - if you want to have anonymous access, add `AllowAnonymousAttribute`.
    - if you add multiple policies to controller, one has to pass all of its policies before access is granted
    - To apply 21 or over policy these lines of code has be to added,
    ```cs
    
    services.AddAuthorization(options =>
    {
        options.AddPolicy("AtLeast21", policy =>
            policy.Requirements.Add(new MinimumAgeRequirement(21)));
    });
    ```

- Authentication is process of determining who you are and authorization is what you are allowed to do in the website.
- Claim is like particular identity. Statement that are validating who they identify as and not what they can do.
- In `Identity`, there are class call `ClaimsIdentity`
- `AuthenticationType` property is like cookies, bearer or google
- Single `ClaimsPrincipal` can contain multiple `Identities`.
---

- `Claim` represents a single facts about the user
    - only contains single piece of information
- In ASP\.NET, proving who you are can be achieved by using `ClaimIdentity`.
- `ClaimPrincipal` represents a user and contains one or more instances of `ClaimIdentitiy`.
- Identity is 