# SendGrid

- SendGrid Email is a cloud based email service that allows responsible transaction email delivery that is built in using c# library
- Send grid account can be signed up using Azure account
- sendgrid can be found in marketplace
- sendgrid requires api key for it to implement
- to use sendgrid, create a template and in solution explorer, reference the nuget packages
- in the nuget packages add send grid
```cs
using SendGrid;
using SendGrid.Helpers.Mail;
```
These two library should be added to the using statement on top

- To create a email use SendGridMessage() to create an object which then can access all of the methods inside.
- Api key can be access through the environment variable which
```cs
var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
var client = new SendGridClient(apiKey);
```
To add the attachment you can create an Attachment object and add `content`,`type`,`filename`,`disposition`, and `contentid` which will be send through `AddAttachment` method in the send method.

` services.AddSingleton<IConfiguration>(Configuration);` this can be added