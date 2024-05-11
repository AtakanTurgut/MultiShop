# MultiShop
Asp.Net Core MultiShop Microservice E-Commerce Site.

```py
http://localhost:5001/api/      =>      Identity Server - Registers
http://localhost:5001/connect/token
https://localhost:7070/api/     =>      Catalog - Categories
https://localhost:7071/api/     =>      Discount - Discounts
https://localhost:7072/api/     =>      Order - Addresses
https://localhost:7073/api/     =>      Cargo - CargoCompanies
```
-----

## Project References
```cs
MultiShop.Order:
    MultiShop.Order.Domain
    Application  =>  Domain
    Persistence  =>  Application + Domain
    
    WebApi       =>  Persistence + Application + Domain
```
```cs
MultiShop.Cargo:
    MultiShop.Cargo.EntityLayer
    DataAccessLayer  =>  EntityLayer
    BusinessLayer    =>  DataAccessLayer + EntityLayer

    WebApi  =>  BusinessLayer + DataAccessLayer + DtoLayer + EntityLayer
```

## Used Packages
Packages can be installed from the "[NuGet Gallery](https://www.nuget.org/packages/Microsoft.AspNet.Identity.Core)" with the help of the `Tools > NuGet Package Manager > Package Manager Console`.

### MultiShop.Catalog - MongoDb
- [MongoDB.Bson 2.25.0](https://www.nuget.org/packages/MongoDB.Bson/2.25.0)
```
    PM> NuGet\Install-Package MongoDB.Bson -Version 2.25.0
```
- [MongoDB.Driver 2.25.0](https://www.nuget.org/packages/MongoDB.Driver/2.25.0)
```
    PM> NuGet\Install-Package MongoDB.Driver -Version 2.25.0
```

- [AutoMapper 12.0.1](https://www.nuget.org/packages/AutoMapper/12.0.1)
```
    PM> NuGet\Install-Package AutoMapper -Version 12.0.1
```
- [AutoMapper.Extensions.Microsoft.DependencyInjection 12.0.1](https://nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection/12.0.1)
```
    PM> NuGet\Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection -Version 12.0.1
```

- [Microsoft.AspNetCore.Authentication.JwtBearer 6.0.25](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.AspNetCore.Authentication.JwtBearer -Version 6.0.25
```

### MultiShop.Discount - MsSQL
- [Microsoft.EntityFrameworkCore 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.Design 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Design -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.SqlServer 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.Tools 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.25
```

- [Dapper 2.1.35](https://www.nuget.org/packages/Dapper/2.1.35)
```
    PM> NuGet\Install-Package Dapper -Version 2.1.35
```

- [Microsoft.AspNetCore.Authentication.JwtBearer 6.0.25](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.AspNetCore.Authentication.JwtBearer -Version 6.0.25
```

### MultiShop.Order.Application
- [MediatR 12.2.0](https://www.nuget.org/packages/MediatR/12.2.0)
```
    PM> NuGet\Install-Package MediatR -Version 12.2.0
```
- [MediatR.Extensions.Microsoft.DependencyInjection 11.1.0](https://www.nuget.org/packages/MediatR.Extensions.Microsoft.DependencyInjection/11.1.0)
```
    PM> NuGet\Install-Package MediatR.Extensions.Microsoft.DependencyInjection -Version 11.1.0
```
- [Microsoft.Extensions.Configuration.Abstractions 6.0.0](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Abstractions/6.0.0)
```
    PM> NuGet\Install-Package Microsoft.Extensions.Configuration.Abstractions -Version 6.0.0
```

### MultiShop.Order.Persistence
- [Microsoft.EntityFrameworkCore 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.Design 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Design -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.SqlServer 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.Tools 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.25
```

### MultiShop.Order.WebApi
- [MediatR 12.2.0](https://www.nuget.org/packages/MediatR/12.2.0)
```
    PM> NuGet\Install-Package MediatR -Version 12.2.0
```
- [MediatR.Extensions.Microsoft.DependencyInjection 11.1.0](https://www.nuget.org/packages/MediatR.Extensions.Microsoft.DependencyInjection/11.1.0)
```
    PM> NuGet\Install-Package MediatR.Extensions.Microsoft.DependencyInjection -Version 11.1.0
```
- [Microsoft.EntityFrameworkCore.Design 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Design -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.Tools 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.25
```

- [Microsoft.AspNetCore.Authentication.JwtBearer 6.0.25](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.AspNetCore.Authentication.JwtBearer -Version 6.0.25
```

### MultiShop.IdentityServer
```html
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="IdentityServer4.AspNetIdentity" Version="4.0.0" />

    <PackageReference Include="Microsoft.AspNetCore.Authentication.Google" Version="6.0.25" />

    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.25" />
    <PackageReference Include="Serilog.AspNetCore" Version="3.2.0" />

    <PackageReference Include="Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore" Version="6.0.25" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="3.1.5" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.25">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>

    <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="6.0.25" />
    <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="6.0.25" />
  </ItemGroup>
</Project>
```

### MultiShop.Cargo
#### MultiShop.Cargo.EntityLayer
- [Microsoft.EntityFrameworkCore 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.Design 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Design -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.SqlServer 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.Tools 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.25
```

#### MultiShop.Cargo.WebApi
- [Microsoft.EntityFrameworkCore.Design 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Design -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.Tools 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.25
```

- [Microsoft.AspNetCore.Authentication.JwtBearer 6.0.25](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.AspNetCore.Authentication.JwtBearer -Version 6.0.25
```