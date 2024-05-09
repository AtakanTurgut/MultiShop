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