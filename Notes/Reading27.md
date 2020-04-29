# Oauth

- `AspNet.Security.OAuth.Providers` and `AspNet.Security.OpenID.Providers` 
- Use secretmananger to store tokens assigned by login provider
```cs
services.AddAuthentication()
    .AddMicrosoftAccount(microsoftOptions => { ... })
    .AddGoogle(googleOptions => { ... })
    .AddTwitter(twitterOptions => { ... })
    .AddFacebook(facebookOptions => { ... });
```

To add multiple authentication providers are using that excerpt

- To create a service provider, you need URI
- Once its registered, client ID and client secret which is used udring the token request process
- The process of Oauth

1. Consumer makes a request to authorization endpoint
2. Service provider authenticate and authroize the access
3. If its authorized, SP redirects back to redirect URI on the website with a temporary access code.
4. The consumer calls the token endpoint which SP exchange the code for a more permanent access token.
5. SP grants an access token which can be used to authenticate 

- `AddCookie()` is a code that will allow cookie authentication handler
- `AddOAuth()` is method that handles OAuth authentication
- `Install-Package Octokit` is way to install Octokit, which is a client library targeting .Net Framework, it makes it easy to access GitHub API