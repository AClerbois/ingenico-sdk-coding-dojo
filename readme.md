![logo](resources/logo.jpg)

# Ingenico Coding Dojo - What is a good SDK?

The purpose of this coding dojo is to have a work framework and a discussion about what is a good SDK? 

## Planning

```
13:00 - Introduction
13:10 - Start thinking and developping your ideal in SDK
14:30 - End hack time and start discussion
15:00 - End of the Coding Dojo 
```

## Context

Ingenico Direct is the next generation solution that will allow our merchants to have an API with the latest WEB standards. But also a simplification of resources by following the HTTP Rest standards.

We have started to develop our API based on the SDK of the Ingenico Connect solution provided by our northern neighbours. 

This integration aims to minimize the integration of merchants using the Connect SDK and who are integrated with Ingenico Belgium

# Challenges

For the SDK, we have several challenges to kick.

- The SDK should fit with all programming language styles;
- Multiple environment can be reach;
- Defines which complexity the SDK should onboard;
- How to work with several version of SDK;

# Resources

## Official Ingenico Direct Documentation

The Ingenico documentation is based on yaml. We use the framework ReDoc to render a Ingenico theme [documentation page](https://support.direct.ingenico.com/documentation/api/reference/index.html#tag/Payments).

[The documentation](contract-definition.yaml) (date of 14th November 2019) is embedded to this GitHub repository 


## SDK Ingenico Server Connect

* [SDK .NET Framework](https://github.com/Ingenico-ePayments/connect-sdk-dotnet)
* [SDK Python 2](https://github.com/Ingenico-ePayments/connect-sdk-python2)
* [SDK Python 3](https://github.com/Ingenico-ePayments/connect-sdk-python3)
* [SDK Ruby](https://github.com/Ingenico-ePayments/connect-sdk-ruby)
* [SDK Java](https://github.com/Ingenico-ePayments/connect-sdk-java)
* [SDK go](https://github.com/Ingenico-ePayments/connect-sdk-go)
* [SDK PHP](https://github.com/Ingenico-ePayments/connect-sdk-php)
* [SDK Node.JS](https://github.com/Ingenico-ePayments/connect-sdk-nodejs)


## Fake Ingenico Direct APIs

I hosted on Microsoft Azure a Fake API to mock Ingenico Direct. 

## Build and deployments

This GitHub has an Continuous integration and deployment using Azure DevOps. The Continuous Integration is based on the [azure-pipelines.yml](azure-pipelines.yml) file. And the deployment allow to deploy on three differents environments called INT, TEST & PROD.

The current status of the build: [![Build Status](https://dev.azure.com/aclerbois-sandbox/ingenico-sdk-fake-direct/_apis/build/status/AClerbois.ingenico-sdk-coding-dojo?branchName=master)](https://dev.azure.com/aclerbois-sandbox/ingenico-sdk-fake-direct/_build/latest?definitionId=11&branchName=master)

### Mock endpoint 

The mock doesn't support HMAC security

#### Environments : 
| Environment   | Entry point url | Swagger url | Deployment Badge |
| -------------:|---------------| -----------|------|
| INT |[https://int-direct.azurewebsites.net](https://int-direct.azurewebsites.net) |[https://int-direct.azurewebsites.net/swagger/index.html](https://int-direct.azurewebsites.net/swagger/index.html)|![Badge INT](https://vsrm.dev.azure.com/aclerbois-sandbox/_apis/public/Release/badge/72d84593-ab89-4fdd-87e7-a2288b333949/1/1)|
| TEST |[https://test-direct.azurewebsites.net](https://test-direct.azurewebsites.net) |[https://test-direct.azurewebsites.net/swagger/index.html](https://test-direct.azurewebsites.net/swagger/index.html)|![Badge TEST](https://vsrm.dev.azure.com/aclerbois-sandbox/_apis/public/Release/badge/72d84593-ab89-4fdd-87e7-a2288b333949/1/2)|
| PROD |[https://prod-direct.azurewebsites.net](https://prod-direct.azurewebsites.net) |[https://prod-direct.azurewebsites.net/swagger/index.html](https://prod-direct.azurewebsites.net/swagger/index.html)|![Badge PROD](https://vsrm.dev.azure.com/aclerbois-sandbox/_apis/public/Release/badge/72d84593-ab89-4fdd-87e7-a2288b333949/1/3)|

### 

# Technical refreshment 

## .NET 

### How to use call an API using HttpClient

```csharp
// HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
static readonly HttpClient client = new HttpClient();
 
static async Task Main()
{
    // Call asynchronous network methods in a try/catch block to handle exceptions.
    try	
    {
        HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        // Above three lines can be replaced with new helper method below
        // string responseBody = await client.GetStringAsync(uri);

     Console.WriteLine(responseBody);
  }  
    catch(HttpRequestException e)
    {
        Console.WriteLine("\nException Caught!");	
        Console.WriteLine("Message :{0} ",e.Message);
    }
}
```
source: [https://docs.microsoft.com/fr-fr/dotnet/api/system.net.http.httpclient?view=netstandard-2.0](https://docs.microsoft.com/fr-fr/dotnet/api/system.net.http.httpclient?view=netstandard-2.0)

Go futher: 

[Make HTTP requests using IHttpClientFactory in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-3.0)

## Author

* **Adrien Clerbois** - [AClerbois](https://github.com/AClerbois)

