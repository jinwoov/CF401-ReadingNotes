# Entity Framework
## EF core Nuget packages
- To add ef core support to a project, install the database provider that you want to target.
- The provider package is `Microsoft.EntityFrameworkCore.SqlServer`.
## Asynchronous Code
- this is the default mode for ASP.NET Core and EF Core
- Web frame uses a lot of thread and sometimes this cou cause high traffic. 
- With synchronous code, many threads are tied up while they aren't acutally doing any work because they're waiting for I/O to complete. 
    - However, with the asynchronous code, when it is waiting for I/O to complete, its thread is freed up for the server to use for processing other requests.
    - This makes the web application more efficient, and able to handle more traffic without delays.
- This is a example of of the code snippet of asynchronous code

```
public async Task<IActionResult> Index()
{
    return View(await _context.Students.ToListAsync());
}
```

- Here `awai` keyword is used compiler to split th method into wo parts, in which the first part ends with the operation thats started asychronously. The second part being that it put into a callback method that's called when the opration is completed
- ToListAsync is a version of async of `ToList`
- 