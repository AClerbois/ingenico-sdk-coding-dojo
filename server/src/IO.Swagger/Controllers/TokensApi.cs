/*
 * Ingenico Direct
 *
 *  # Introduction  The Ingenico Direct API has been designed as a REST API. It uses the HTTP protocol as its foundation. Each resource is accessible under a clearly named URL and the HTTP response codes are used to relay status. HTTP Verbs like GET and POST are used to interact with the resources. To support accessibility by clients directly, as opposed to your server, our servers support cross-origin resource sharing. We use JSON for all of our payloads, including error messages   All these characteristics mean that you will be able to use standard off the shelf software to interact with Ingenico ePayments. To make the integration even easier, Ingenico ePayments also has SDKs that wrap both the complete Server API as well as the complete Client API. 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class TokensApiController : ControllerBase
    { 
        /// <summary>
        /// Get token
        /// </summary>
        /// <remarks>Use GET on a specific token to retrieve all the tokenized data for that ID. You can use some of this data towards the consumer to let them choose which stored data to re-use. You can also use data like the expiry date to check if you need to ask for updated data from your consumer.  We will never return full card details.</remarks>
        /// <param name="merchantId">The Merchant Id</param>
        /// <param name="tokenId">The Token Id</param>
        /// <response code="200">All non-sensitive data that is stored is returned.</response>
        /// <response code="400">Bad request</response>
        /// <response code="404">In case you are trying to retrieve a token that does not exist or has been deleted.</response>
        [HttpGet]
        [Route("/v1/{merchantId}/tokens/{tokenId}")]
        [ValidateModelState]
        [SwaggerOperation("TokensGetToken")]
        [SwaggerResponse(statusCode: 200, type: typeof(TokenResponse), description: "All non-sensitive data that is stored is returned.")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad request")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "In case you are trying to retrieve a token that does not exist or has been deleted.")]
        public virtual IActionResult TokensGetToken([FromRoute][Required]string merchantId, [FromRoute][Required]string tokenId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TokenResponse));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));

            string exampleJson = null;
            exampleJson = "{\n  \"paymentProductId\" : 0,\n  \"eWallet\" : {\n    \"data\" : {\n      \"billingAgreementId\" : \"billingAgreementId\"\n    },\n    \"alias\" : \"alias\",\n    \"customer\" : {\n      \"companyInformation\" : {\n        \"name\" : \"name\"\n      },\n      \"personalInformation\" : {\n        \"name\" : {\n          \"firstName\" : \"firstName\",\n          \"surnamePrefix\" : \"surnamePrefix\",\n          \"surname\" : \"surname\"\n        }\n      },\n      \"merchantCustomerId\" : \"merchantCustomerId\",\n      \"billingAddress\" : {\n        \"zip\" : \"zip\",\n        \"city\" : \"city\",\n        \"countryCode\" : \"countryCode\",\n        \"street\" : \"street\",\n        \"additionalInfo\" : \"additionalInfo\",\n        \"houseNumber\" : \"houseNumber\",\n        \"stateCode\" : \"stateCode\",\n        \"state\" : \"state\"\n      },\n      \"vatNumber\" : \"vatNumber\"\n    }\n  },\n  \"id\" : \"id\",\n  \"card\" : {\n    \"data\" : {\n      \"firstTransactionDate\" : \"firstTransactionDate\",\n      \"cardWithoutCvv\" : \"\",\n      \"providerReference\" : \"providerReference\"\n    },\n    \"alias\" : \"alias\",\n    \"customer\" : {\n      \"companyInformation\" : {\n        \"name\" : \"name\"\n      },\n      \"personalInformation\" : {\n        \"name\" : {\n          \"firstName\" : \"firstName\",\n          \"surnamePrefix\" : \"surnamePrefix\",\n          \"surname\" : \"surname\"\n        }\n      },\n      \"merchantCustomerId\" : \"merchantCustomerId\",\n      \"billingAddress\" : {\n        \"zip\" : \"zip\",\n        \"city\" : \"city\",\n        \"countryCode\" : \"countryCode\",\n        \"street\" : \"street\",\n        \"additionalInfo\" : \"additionalInfo\",\n        \"houseNumber\" : \"houseNumber\",\n        \"stateCode\" : \"stateCode\",\n        \"state\" : \"state\"\n      },\n      \"vatNumber\" : \"vatNumber\"\n    }\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TokenResponse>(exampleJson)
            : default(TokenResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
