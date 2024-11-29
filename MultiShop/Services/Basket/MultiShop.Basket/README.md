```cs
Redis - BasketDb - localhost,6379
```

## Portainer
```cs
http://localhost:9000/
Username : admin
Password : Aa123456789+
```

```bash
App Templates
Redis

1.
Name     : BasketDb
+ Hide advanced options
host : 6379
```

# appsettings.json
```json
  "RedisSettings": {
    "Host": "localhost",
    "Port": 6379
  }
```

## sub - mapping
![](https://raw.githubusercontent.com/AtakanTurgut/MultiShop/main/images/jwtMappingSub.png)

## sub - non-mapping
![](https://raw.githubusercontent.com/AtakanTurgut/MultiShop/main/images/jwtNon_MappingSub.png)

## jwt Basket
![](https://raw.githubusercontent.com/AtakanTurgut/MultiShop/main/images/jwtBasket.PNG)

#### https://localhost:7074/api/Baskets - POST
Body - raw - JSON <br />
Authorization - OAuth 2.0
```json
{
    "UserId": "5df76786-9715-4a8b-8761-5abfdfc26360",
    "DiscountCode": "null",
    "DiscountRate": 0,
    "BasketItems":  [
        {
            "ProductId": "abcdef-1",
            "ProductName": "Bilgisayar",
            "Quantity": 1,
            "Price": 28000
        },
        {
            "ProductId": "abcdef-2",
            "ProductName": "Masa",
            "Quantity": 2,
            "Price": 2500
        }
    ]
}
```