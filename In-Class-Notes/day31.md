Authorizatoin you are allow to do 

-admin 


- in the `applicationUser`
```cs
public static class ApplicaitionRoles()
{
    public const string Member = "Member";
    public const string Admin = "Admin";
    public const string DogMan = "Jin"
}

```
In the Data
```cs
create a model // Model/RoleInitalizer


private static readonly List<IdentityRoles>()
{
    new IdentityRoles{Name = ApplicationRoles.Member, NormalizedName = ApplicationRoles.Member.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
    new IdentityRoles {Name = ApplicationRoles.Admin, NormalizedName = ApplicationRoles.Admin.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
    new IdentityRoles {Name = ApplicationRoles.DogMan, NormalizedName = ApplicationRoles.DogMan.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() }
};

// serviceprovider is like delegate and serve it
public static void SeedData(IServiceProvider serviceProvider) 
{
    using (var dbContext = new ApplicationContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>))
    {
        // checking if the database is exiting
        dbContext.Database.EnsureCreated();
        // Add roles to the db
        AddRoles(dbContext);
    }

}

private static void AddRoles(ApplicationDbContext context)
{
    // returns if roles exist
    if(context.Roles.Any()) return;

    foreach (var role in Roles)
    {
        context.Roles.Add(role);
        context.SaveChanges();
    }
}
```

At startup.cs
```cs


inject IServiceProvider serviceProvider

// after the routing

RoleInitializer.SeedData(serviceProvider);



```

in th register day 29
```cs
_userManger......

```


add page call razor page in page/data/razorpage

- [Authorize()]


```cs


```

In Program.cs under configure

```cs

//under congifguratoin
services.AddAuthorization(options => 
{
    options.AddPolicy("AdminOnly", policy => policy.RequireRole(ApplicationRoles.Admin));
});


app.UseAuthentication();
// under
app.UseAuthorization();

```


In page/admin folder razorpage

<h1>Welcome admin! </h1>

in Admin pag
```cs
 [Authorize(Policy = "AdminOnly" )]
```

in the account add AccessDenied

and fill cannot do that text


