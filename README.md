# SCILL - the C# library for the SCILL API

SCILL gives you the tools to activate, retain and grow your user base in your app or game by bringing you features well known in the gaming industry: Gamification. We take care of the services and technology involved so you can focus on your game and content.

Some parts of this C# SDK are automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using SCILL.Api;
using SCILL.Client;
using SCILL.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out SCILL.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="about-scill"></a>
## About SCILL

SCILL is a fully customizable toolkit that enables you to integrate tailored challenges and full-fledged Battle Passes 
to your game, app and website. SCILL connects seamlessly to your user account and payment systems, adding new retention 
and monetization layers within minutes.

Learn more about SCILL here: [https://www.scillgaming.com](https://www.scillgaming.com).

Developer documentation can be found here: [https://developers.scillgame.com](https://developers.scillgame.com) 

<a name="getting-started"></a>
## Getting Started

The API has two main entries: `SCILLBackend` and `SCILLClient`. The `SCILLBackend` class requires an API key to initialize and
should only be used in safe environments like a backend. `SCILLBackend` is also used to generate an access token that is required
when initializing the `SCILLClient` class. `SCILLClient` offers client side functionality like sending events and querying users
challenges and battle passes.

More info about that can be found in our extensive developer documentation: [https://developers.scillgame.com](https://developers.scillgame.com).

Both classes `SCILLBackend` and `SCILLClient` wrap OpenAPI auto generated APIs like `ChallengesApi`. You may use them directly, have
a look in the source of `SCILLBackend` and `SCILLClient` on how to set the API key or Access Token required for the backend REST APIs. 

```csharp
using System;
using System.Diagnostics;
using SCILL.Api;
using SCILL.Client;
using SCILL.Model;

namespace Example
{
    public class Example
    {
        SCILLClient _scillClient;

        public void main()
        {
            // Initialize the SCILLClient with access token and APP_ID 
            _scillClient = new SCILLClient(_accessToken, "YOUR_APP_ID");

            // Load challenges and iterate through categories and challenges
            List<ChallengeCategory> categories = await _scillClient.GetPersonalChallengesAsync();
            foreach (ChallengeCategory category in categories)
            {
                foreach (Challenge challenge in category.challenges)
                {
                    // Do something with a challenge - like adding it to a list view
                }
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://virtserver.swaggerhub.com/4Players-GmbH/scill-gaas/1.0.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthApi* | [**GenerateAccessToken**](docs/AuthApi.md#generateaccesstoken) | **POST** /api/v1/auth/access-token | Get an access token for any user identifier signed with the API-Key
*BattlePassesApi* | [**ClaimBattlePassLevelReward**](docs/BattlePassesApi.md#claimbattlepasslevelreward) | **POST** /api/v1/battle-passes/{appId}/{bpid}/claim-level | Claim the reward of a finished personal challenge
*BattlePassesApi* | [**GetBattlePass**](docs/BattlePassesApi.md#getbattlepass) | **GET** /api/v1/battle-passes/{appId}/{bpid} | Get battle passe by id
*BattlePassesApi* | [**GetBattlePasses**](docs/BattlePassesApi.md#getbattlepasses) | **GET** /api/v1/battle-passes/{appId} | Get battle passes
*BattlePassesApi* | [**UnlockBattlePassLevel**](docs/BattlePassesApi.md#unlockbattlepasslevel) | **POST** /api/v1/battle-passes/{appId}/{bpid}/unlock | Unlock the level of a battle pass
*ChallengesApi* | [**ActivatePersonalChallenge**](docs/ChallengesApi.md#activatepersonalchallenge) | **PUT** /api/v1/challenges/personal/activate/{appId}/{cid} | Activate a personal challenges
*ChallengesApi* | [**CancelPersonalChallenge**](docs/ChallengesApi.md#cancelpersonalchallenge) | **PUT** /api/v1/challenges/personal/cancel/{appId}/{cid} | Cancel an active personal challenges
*ChallengesApi* | [**ClaimPersonalChallengeReward**](docs/ChallengesApi.md#claimpersonalchallengereward) | **PUT** /api/v1/challenges/personal/claim/{appId}/{cid} | Claim the reward of a finished personal challenge
*ChallengesApi* | [**GenerateWebsocketAccessToken**](docs/ChallengesApi.md#generatewebsocketaccesstoken) | **GET** /api/v1/challenges/web-socket/generate-token | Get an access token for the Websockets server notifying of updates in real time
*ChallengesApi* | [**GetActivePersonalChallenges**](docs/ChallengesApi.md#getactivepersonalchallenges) | **GET** /api/v1/challenges/personal/get-in-progress-challenges/{appId} | Get active personal challenges
*ChallengesApi* | [**GetPersonalChallenges**](docs/ChallengesApi.md#getpersonalchallenges) | **GET** /api/v1/challenges/personal/get/{appId} | Get personal challenges
*ChallengesApi* | [**UnlockPersonalChallenge**](docs/ChallengesApi.md#unlockpersonalchallenge) | **POST** /api/v1/challenges/personal/unlock/{appId}/{cid} | Unlock a personal challenges
*EventsApi* | [**SendEvent**](docs/EventsApi.md#sendevent) | **POST** /api/v1/events | Post an event

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccessToken](docs/AccessToken.md)
 - [Model.ActionResponse](docs/ActionResponse.md)
 - [Model.BattlePass](docs/BattlePass.md)
 - [Model.BattlePassLevel](docs/BattlePassLevel.md)
 - [Model.BattlePassLevelChallenge](docs/BattlePassLevelChallenge.md)
 - [Model.BattlePassLevelId](docs/BattlePassLevelId.md)
 - [Model.Challenge](docs/Challenge.md)
 - [Model.ChallengeCategory](docs/ChallengeCategory.md)
 - [Model.ChallengeWebhookPayload](docs/ChallengeWebhookPayload.md)
 - [Model.Error](docs/Error.md)
 - [Model.EventMetaData](docs/EventMetaData.md)
 - [Model.EventPayload](docs/EventPayload.md)
 - [Model.ForeignUserIdentifier](docs/ForeignUserIdentifier.md)
 - [Model.SocketToken](docs/SocketToken.md)
 - [Model.UnknownChallengeError](docs/UnknownChallengeError.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKeyType"></a>
### ApiKeyType

- **Type**: API key
- **API key parameter name**: auth
- **Location**: URL query string

<a name="BearerAuth"></a>
### BearerAuth


<a name="oAuthNoScopes"></a>
### oAuthNoScopes

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: https://api.example.com/oauth2/authorize
- **Scopes**: 
  - : 

