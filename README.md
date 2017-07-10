# BlinfoApiWrapper
Ths BlInfoApiWrapper project is a .Net Standard 1.4 compatible API wrapper for the Björn Lundén Information REST API. 

# Prerequisits
Your must first register as a developer with the Björn Lundén Information organisation. You will then receive a ClientId and a ClientSecret that are used when connecting to the API. 

# Usage
Connecting to the Björn Lundén Information API is a two step process where you first connect using your ClientId and ClientSecret credentials and then select which Björn Lundén Information client you want to work with. Client, in this context, refers to a paying Björn Lundén Information customer who has selected to use your integration solution. 

# Example
```csharp
// Set up an authenticationSession and connect using BL credentials
var authenticationSession = SessionFactory.GetAuthenticationSession(ClientId, ClientSecret);
if (!await authenticationSession.Connect()) return;

// Use CommonStore to access all meta resources. In this case; find all clients that are avaiable to us and select the first one
var client = (await authenticationSession.CommonStore.GetClientsAsync()).FirstOrDefault();
if (client == null) return;

// Set up a client session for the selected client
var session = SessionFactory.GetClientSession(authenticationSession, client.PublicKey);

// Fetch all the articles for the selected client. 
// You can find all available data stores in the Client session, e.g. CustomerInvoiceStore, AccountStore, et.c. 
var articles = await session.ArticleStore.GetAllAsync();
foreach (var article in articles)
{
    Console.WriteLine($"{article.Id} - {article.Name}");
}
```
