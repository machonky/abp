# ABP.IO Platform 7.0 RC Has Been Released

Today, we are happy to release the [ABP Framework](https://abp.io/) and  [ABP Commercial](https://commercial.abp.io/) version **7.0 RC** (release candidate). This blog post introduces the new features and important changes in this new version.

Try this version and provide feedback for the stable ABP v7.0! Thank you to all.

## Get Started with the 7.0 RC

Follow the steps below to try version 7.0.0 RC today:

1) **Upgrade** the ABP CLI to version `7.0.0-rc.1` using a command line terminal:

````bash
dotnet tool update Volo.Abp.Cli -g --version 7.0.0-rc.1
````

**or install** it if you haven't before:

````bash
dotnet tool install Volo.Abp.Cli -g --version 7.0.0-rc.1
````

2) Create a **new application** with the `--preview` option:

````bash
abp new BookStore --preview
````

See the [ABP CLI documentation](https://docs.abp.io/en/abp/latest/CLI) for all the available options.

> You can also use the [Get Started](https://abp.io/get-started) page to generate a CLI command for creating an application.

You can use any IDE that supports .NET 7.x, like **[Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)**.

## Migration Guides

There are breaking changes in this version that may affect your application. 
Please see the following migration documents, if you are upgrading from v6.0:

* [ABP Framework 6.x to 7.0 Migration Guide](https://docs.abp.io/en/abp/7.0/Migration-Guides/Abp-7_0)
* [ABP Commercial 6.x to 7.0 Migration Guide](https://docs.abp.io/en/commercial/7.0/migration-guides/v7_0)

## What's New with ABP Framework 7.0?

In this section, I will introduce some major features released in this version. Here is a brief list of titles explained in the next sections:

* Upgraded to .NET 7.0
* ABP Dapr Integration
* Upgraded to OpenIddict 4.0
* Dynamic Features
* Integration Services
* External Localization Infrastructure
* Dynamic Permissions
* Distributed Entity Cache Base Class
* Layout Hooks for the Blazor UI
* CMS Kit New Features 
* Improvements on **eShopOnAbp**
* Other news...

### Upgraded to .NET 7.0

Upgraded to .NET 7.0, so you need to move your solutions to .NET 7.0 if you want to use the ABP 7.0.

> You can check the [Migrate from ASP.NET Core 6.0 to 7.0](https://learn.microsoft.com/en-us/aspnet/core/migration/60-70?view=aspnetcore-7.0) documentation. Also, there is a community article to show how to upgrade an existing project to .NET 7.0. You can check it from 👉 [here](https://community.abp.io/posts/upgrade-your-existing-projects-to-.net7-nmx6vm9m).

### ABP Dapr Integration

[Dapr (Distributed Application Runtime)](https://dapr.io/) provides APIs that simplify microservice connectivity.

ABP and Dapr have some intersecting features like service-to-service communication, distributed message bus and distributed locking. However, their purposes are totally different. 

ABP's goal is to provide an end-to-end developer experience with an opinionated architecture. On the other hand, Dapr's purpose is to provide a runtime to decouple common microservice communication patterns from your application logic.

ABP 7.0 offers some packages to provide better integration with Dapper.

> I will cover some important integration notes below but if you want to get a full overview of ABP Dapr Integration please see the [ABP Dapr Integration documentation](https://docs.abp.io/en/abp/7.0/Dapr/Index).

#### Distributed Event Bus Integration

ABP's [Distributed Event Bus System](https://docs.abp.io/en/abp/7.0/Distributed-Event-Bus) provides a convenient abstraction to allow applications to communicate asynchronously via events. 

ABP's [Volo.Abp.EventBus.Dapr](https://www.nuget.org/packages/Volo.Abp.EventBus.Dapr) and [Volo.Abp.AspNetCore.Mvc.Dapr.EventBus](https://www.nuget.org/packages/Volo.Abp.AspNetCore.Mvc.Dapr.EventBus) packages make it possible to use the Dapr infrastructure with the ABP's distributed event bus.

> **Volo.Abp.EventBus.Dapr** package is used to publish events and on other hand the **Volo.Abp.AspNetCore.Mvc.Dapr.EventBus** package is used to subscribe to these events.

> See [the documentation](https://docs.abp.io/en/abp/7.0/Dapr/Index#distributed-event-bus-integration) to learn more.

#### C# API Client Proxies Integration

ABP can [dynamically](https://docs.abp.io/en/abp/7.0/API/Dynamic-CSharp-API-Clients) or [statically](https://docs.abp.io/en/abp/7.0/API/Static-CSharp-API-Clients) generate proxy classes to invoke your HTTP APIs from a Dotnet client application. 

The [Volo.Abp.Http.Client.Dapr](https://www.nuget.org/packages/Volo.Abp.Http.Client.Dapr) package configures the client-side proxy system, so it uses Dapr's service invocation building block for the communication between your applications.

> See [the documentation](https://docs.abp.io/en/abp/7.0/Dapr/Index#c-api-client-proxies-integration) to learn more.

#### Distributed Lock

ABP provides a [Distributed Locking](https://docs.abp.io/en/abp/7.0/Distributed-Locking) abstraction to control access to a shared resource by multiple applications. Dapr also has a [distributed lock building block](https://docs.dapr.io/developing-applications/building-blocks/distributed-lock/). 

The [Volo.Abp.DistributedLocking.Dapr](https://www.nuget.org/packages/Volo.Abp.DistributedLocking.Dapr) package makes ABP use Dapr's distributed locking system.

> See [the documentation](https://docs.abp.io/en/abp/7.0/Dapr/Index#distributed-lock) to learn more.

### Upgraded to OpenIddict 4.0

OpenIddict 4.0 preview has been released on June 22. So, we decided to upgrade the OpenIddict packages to 4.0-preview in ABP 7.0.

Once the final release of OpenIddict 4.0 is published, we will immediately upgrade it to the stable version and plan to make ABP 7.0 final to use the OpenIddict 4.0 stable version.

> You can read the "[OpenIddict 4.0 preview1 is out](https://kevinchalet.com/2022/06/22/openiddict-4-0-preview1-is-out/)" post to learn what's new with OpenIddict 4.0.

### Dynamic Features

//TODO: (@hikalkan)

### Integration Services 

//TODO: (@hikalkan)

### External Localization Infrastructure

//TODO: (@hikalkan)

### Dynamic Permissions

//TODO: (@hikalkan)

### Distributed Entity Cache Base Class

ABP introduces **Distributed Entity Cache Base Class** with v7.0. 

There is an `EntityCache<>` base class that can help you if you want to cache entities. This base class helps you to easily implement caching for entities.

> Check [this PR](https://github.com/abpframework/abp/pull/14055) to see the implementation and additional notes.

### Layout Hooks for the Blazor UI

The **Layout Hook System** allows you to add code to some specific parts of the layout and all layouts of the themes provided by the ABP Framework implement these hooks. 

This system was already implemented for MVC UI but not for the Blazor UI. 

We've announced in the previous blog post ([ABP 6.0 Release Candidate blog post](https://blog.abp.io/abp/ABP.IO-Platform-6.0-RC-Has-Been-Published)) to we're planning to implement it in version 7.0.

And now, we are introducing the Layout Hook System for Blazor UI as planned within this version. 

> You can read the [Blazor UI: Layout Hooks](https://docs.abp.io/en/abp/7.0/UI/Blazor/Layout-Hooks) documentation if you want to use the Layout Hooks in your Blazor application and see the required configurations.

### CMS Kit - New Features

There are two new features that came with this version on the CMS Kit module:

#### Features Integration

![](cms-kit-features.png)

ABP's [Feature System](https://docs.abp.io/en/abp/latest/Features) is used to **enable**, **disable** or **change the behavior** of the application features on runtime. In ABP 7.0, this is implemented for the CMS Kit module.

#### Set a Page as the Homepage

![](cms-kit-homepage.png)

ABP 7.0 introduces a new feature on the CMS Kit module and that allows you to set any page as the home page (if you haven't created a homepage in your code such as `/Pages/Index.cshtml` for Razor Page applications). Then when the users access your website, they will see this page as the homepage.

### Improvements on eShopOnAbp

The following improvements have been made on the [eShopOnAbp project](https://github.com/abpframework/eShopOnAbp) within this version:

* Keycloak is an open-source identity management system. Keycloak Integration has been added to the project within this release period. See [#12021](https://github.com/abpframework/abp/issues/12021) for more info.
* The product detail page now uses CMS Kit's [Rating](https://docs.abp.io/en/abp/latest/Modules/Cms-Kit/Ratings) and [Comment](https://docs.abp.io/en/abp/latest/Modules/Cms-Kit/Comments) features. See [#11429](https://github.com/abpframework/abp/issues/11429) for more info.

### Other News

* ABP 7.0 introduces the `AbpDistributedLockOptions` for the main options class to configure the distributed locking. You can specify any name as the lock prefix by configuring the `AbpDistributedLockOptions`. See the [documentation](https://docs.abp.io/en/abp/7.0/Distributed-Locking#abpdistributedlockoptions) for more.

## What's New with ABP Commercial 7.0?

### External Localization System in the Language Management Module

//TODO: (@hikalkan)

### Set Tenant Admin's Password from Host

![](tenant-admin-password.gif)

ABP 7.0 allows setting the tenant admin's password from the Host side. You can set a new password to any tenant admin's password from the Tenants page if you are the Host of the system.

### WeChat and Alipay Integrations for the Payment Module

![](payment-gateway-1.png)

In this version, WeChat Pay and Alipay gateways have been added to the payment module.

You can read the [Payment Module documentation](https://docs.abp.io/en/commercial/7.0/modules/payment#alipayoptions) for configurations and more info.

### Others

* Project Dependencies removed from the Administration Service for Microservice Pro Template.
* CMS Kit - Contact Feature allows multiple(named) contact forms with this version. Now, you can add different contact forms on different pages (with different settings).


## Community News

### New ABP Community Posts

* [gdlcf88](https://github.com/gdlcf88) has created a new community article. You can read it 👉 [here](https://community.abp.io/posts/use-stepping-to-perform-atomic-multistep-operations-4kqu8ewp).
* [GDUnit](https://community.abp.io/members/GDUnit) has created her/his first ABP community article that shows multi-tenant subdomain resolution in blazor applications. You can read it 👉 [here](https://community.abp.io/posts/abp-blazor-multitenant-subdomain-resolution-c1x4un8x).
* [EngincanV](https://twitter.com/EngincanVeske) has created a new community article to introduce the ABP's testing infrastructure. You can read it 👉 [here](https://community.abp.io/posts/testing-in-abp-framework-with-examples-3w29v6ce).
* [Alper Ebicoglu](https://twitter.com/alperebicoglu) has created a new community article to show "How to upgrade an existing project to .NET7". You can read it 👉 [here](https://community.abp.io/posts/upgrade-your-existing-projects-to-.net7-nmx6vm9m).
* [Kirti Kulkarni](https://community.abp.io/members/kirtik) has created a new community article to show "How to integrate and enable the Chat Module in an ABP Commercial application". You can read it 👉 [here](https://community.abp.io/posts/integrating-and-enabling-the-chat-module-in-abp-commercial-vsci3ov2).

### Volosoft Has Attended the .NET Conf 2022

![](dotnef-conf-2022.jpg)

Halil İbrahim Kalkan, the lead developer of ABP Framework attended [.NET Conf 2022](https://www.dotnetconf.net/) on November 10, 2022. His topic was "Authorization in a Distributed / Microservice System". In this talk, he talked about permission-based authorization systems and its challenges. Then, gave solutions that are implemented in open source ABP Framework. 

You can watch his speech from 👉 [here](https://www.youtube.com/watch?v=DVqvRZ0w-7g).

### Community Talks 2022.9: .NET 7.0 & ABP 7.0

![](community-talks-cover-image.png)

In this episode of ABP Community Talks, 2022.9; we'll talk about .NET 7.0 and ABP 7.0 with ABP Core Team. We will dive into the features that came with .NET 7.0, how they are implemented in ABP 7.0, the highlights in the .NET Conf 2022 with [Halil İbrahim Kalkan](https://github.com/hikalkan), [Alper Ebicoglu](https://github.com/ebicoglu), [Engincan Veske](https://github.com/EngincanV), [Hamza Albreem](https://github.com/braim23) and [Bige Besikci Yaman](https://github.com/bigebesikci). 

> Register to listen and ask your questions now 👉 https://kommunity.com/volosoft/events/abp-community-20229-net-70-abp-70-f9e8fb72 .

## Conclusion 

This version comes with some features and enhancements to the existing features. You can see the [Road Map](https://docs.abp.io/en/abp/7.0/Road-Map) documentation to learn about the release schedule and planned features for the next releases. Please try the ABP v7.0 RC and provide feedback to us. 

Thanks for being a part of this community!