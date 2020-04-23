# Policies

- To add authorization of policy
```cs
 services.AddAuthorization(options =>
    {
        // AtLeast21 is policy created 
        options.AddPolicy("AtLeast21", policy =>
            policy.Requirements.Add(new MinimumAgeRequirement(21)));
    });
```

- `IAuthorizationRequirement` is a way to track if authorization was successful
- `IAuthorizationHandler` are responsible for checking if requirements were met.
- TO inject the policies to the MVC data annotation can bee used of `[Authorize(Policy="xxx")]` 

To apply authorize to razor page
```cs
services.AddMvc()
    .AddRazorPagesOptions(options =>
    {
        /// requiring authorizing to access the page
        options.Conventions.AuthorizePage("/Contact");
        // requiring authorizing to access folder of the page
        // To specify, use overload of 
        options.Conventions.AuthorizeFolder("/Private" //, "AtLeast21");
        // to allow anonymous user to access page and folder
        options.Conventions.AllowAnonymousToPage("/Private/PublicPage");
        options.Conventions.AllowAnonymousToFolder("/Private/PublicPages");
    })
    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
```

- To use requirement implement `IAuthorizationRequirement` which then use constructor to take in int or string that will be set to check the requirement.
- context.succeed will be invoked with the satisfied requirement as its sole parameter
- Use handler for multiple requirements
    - run the loop to the `PendingRequirements` and see if its matching the `IsOwner or IsSponsor`
- 