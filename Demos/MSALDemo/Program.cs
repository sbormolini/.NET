using Microsoft.Identity.Client;

// source https://docs.microsoft.com/en-us/learn/modules/implement-authentication-by-using-microsoft-authentication-library/3-initialize-client-applications

var clientId = "";
var clientSecret = "";

string redirectUri = "https://myapp.azurewebsites.net";

// Initializing public and confidential client applications
IConfidentialClientApplication app = ConfidentialClientApplicationBuilder.Create(clientId)
    .WithClientSecret(clientSecret)
    .WithRedirectUri(redirectUri)
    .Build();

//// build modifiers
//var clientApp = PublicClientApplicationBuilder.Create(client_id)
//    .WithAuthority(AzureCloudInstance.AzurePublic, tenant_id)
//    .Build();

//var clientApp = PublicClientApplicationBuilder.Create(client_id)
//    .WithAuthority(AzureCloudInstance.AzurePublic, tenant_id)
//    .WithRedirectUri("http://localhost")
//    .Build();