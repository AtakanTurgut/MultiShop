## MultiShop.IdentityServer

Install IdentityServer netcoreapp3.1.

```bash
PS > dotnet new -i identityserver4.templaters
```
```bash
Şu şablon paketleri yüklenecek:
   identityserver4.templates

Başarılı: IdentityServer4.Templates::4.0.1 şu paketleri yükledi:
Şablon Adı                                            Kısa Ad   Dil   Etiketler
----------------------------------------------------  --------  ----  -------------------
IdentityServer4 Empty                                 is4empty  [C#]  Web/IdentityServer4
IdentityServer4 Quickstart UI (UI assets only)        is4ui     [C#]  Web/IdentityServer4
IdentityServer4 with AdminUI                          is4admin  [C#]  Web/IdentityServer4
IdentityServer4 with ASP.NET Core Identity            is4aspid  [C#]  Web/IdentityServer4
IdentityServer4 with Entity Framework Stores          is4ef     [C#]  Web/IdentityServer4
IdentityServer4 with In-Memory Stores and Test Users  is4inmem  [C#]  Web/IdentityServer4
```

Create IdentityServer Template.

```bash
PS MultiShop\IdentityServer> dotnet new is4aspid --name MultiShop.IdentityServer
```
```bash
"IdentityServer4 with ASP.NET Core Identity" şablonu başarıyla oluşturuldu.

Oluşturma sonrası eylemleri işleniyor...
Şablon şu eylemi çalıştıracak şekilde yapılandırıldı:
Güncel komut: dotnet run /seed
Bu eylemi çalıştırmak istiyor musunuz [Y(evet)|N(hayır)]?
n

Çıkış koduyla ilgili ayrıntılar için şu sayfaya bakın: https://aka.ms/templating-exit-codes#104
```

## Portainer
```cs
http://localhost:9000/
Username : admin
Password : Aa123456789+
```

```bash
App Templates
SQL Server - linux container

1.
Name     : IdentityDb
Password : Aa123456+
+ Hide advanced options
- Published Ports
host : 1433
container : 1433

> Deploy the container
```

## DBeaver
```
SQL Server - port 1433
Username : sa
Password : Aa123456+
```

## Migrations
Use this commands for the `Migration Operations`:
```cs
    > dotnet ef migrations -h
    > dotnet ef database -h
```
- Create Migration  
```
    > dotnet ef migrations add init 
```
- Update Data   (Add Configurations)
```
    > dotnet ef database update
```
- Drop the Database
```
    > dotnet ef database drop
    ? Y
```
- Delete Migrations
```
    > del .\Migrations\
    ? A
```

- [ ] If you get an error like this:
```
> Update-Database 
To change the IDENTITY property of a column, the column needs to be dropped and recreated.
``` 
Remove `MultiShopIdentityDb` database from `DBeaver master - 1433 port`. <br />
Remove the `Migrations` folder in the `Data` folder and update the database (`Update-Database`) again via Migrations (`Add-Migration init`).

-----

#### https://localhost:5001/api/Registers - POST
Body - raw - JSON
```json
{
    "UserName":"atakanturgut",
    "Email":"atakan.trgt@hotmail.com",
    "Name":"Atakan",
    "Surname":"Turgut",
    "Password":"Aa123456+"
}
```