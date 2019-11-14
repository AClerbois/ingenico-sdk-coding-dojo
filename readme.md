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



## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Billie Thompson** - *Initial work* - [PurpleBooth](https://github.com/PurpleBooth)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc
