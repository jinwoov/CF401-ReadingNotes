# Views & Azure Deployment

- default layout for an ASP.NET Core app is name *_Layout.cshtml* 
- ` asp-fallback-href` is a fallback ref incase one is down
```
@{
    Layout = "_Layout";
}
```
- This has to be added for the layout to be integrated.
- When a partial name is provided, the Razor view engine searches for the layout file using its standard discovery process.

## Sections
- it can be organized in certain page elements and can use `RenderSection` that can specify whether that section is required or optional
` @RenderSection("Scripts", required: false)`

```cs
@section Scripts {
    <partial name="_ValidationScriptsPartial" />
}
```
- this is way for Partial Tag Helper to render `_ValidationScriptsPartial`

```cs
@using WebApplication1
@using WebApplication1.Models
@using WebApplication1.Models.AccountViewModels
@using WebApplication1.Models.ManageViewModels
@using Microsoft.AspNetCore.Identity
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
```

- This is what sample `_ViewImports.cshtml`.
- Tag helper is server side code that particpate in creating rendering HTML elements in Razor files.
- for example `ImageTagHelper` is to append version number to the image name
- `asp-for` is a tag that you can use for razor markup
