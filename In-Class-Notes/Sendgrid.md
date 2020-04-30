- Hit create resource
- search sendgrid
- pay as you go
- create a account
- you will get a secret and api key
- put the api in the top part of configuration
- resource - manage
- setting api key
- mail send and full access
- then name 
- restricted access
- copy it
- in secret json

```json
"ConnectionStrings"{
}
"SendGrid-Key": "API"
```

nuget package and install-package sendgrid - version 9.14.0
In `Service` - `    ` (email sender) - implement IEmailSender


`Install-Package Microsoft.AspNetCore.Identity.UI -Version 3.1.3`

<!-- send email through send grid to required location -->
```cs

private readonly IConfiguration _configuration;

public EmailSender(IConfiguration configuration)
{
    _configuration = configuration
}

public async Task SendEmailAsync(string email, string subject, string htmlMessage)
{
    SendGridClient client =  new SendGridClient(_configuration["SendGridKey"]);
    SendGridMessage msg = new SendGridMessage();

    // email, and name
    msg.SetFrom("jinwoov@gmail.com", "Site Admin");
    msg.AddTo(email);
    msg.SetSubject(subject);
    msg.AddContent(MimeType.Html, htmlMessage)
    

    await client.SendEmailAsync(msg);

}
```
- Transient: every time
-  scoped: One policy
-  Singleton: one time through the lifecycle



In startup

```cs
services.AddTransient<IEmailSender, EmailSender>();

add a form in the 

<form asp-action="SendEmail" method="post">

```
in controller

```cs
private readonly IEmailSender _email;

public HomeController(IEmailSender email)
{
    _email = email
}
[HttpPost]
public IActionResult SendEmail()
{
    StringBuilder sb = new StringBuilder();
    sb.AppendLine("<h1> jin </h1>");
    sb.AppendLine("<p>adsfsafsfsa</p>")

    _email.SendEmailAsync("amanda@codefellows.com", "My Email is working", sb.ToString());

    return View();
}

```

adding a string a extra space to heap. so if its concatention

string builder only happens when its called

striing builder is way to create a text only happens once