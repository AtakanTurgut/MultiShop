```cs
CargoDb - localhost,1441
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

3.
Name     : CargoDb
Password : Aa123456+ 
+ Hide advanced options
- Published Ports
host : 1441 
container : 1433

> Deploy the container
```

# DBeaver
```
3.
SQL Server - port 1441
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

#### https://localhost:7073/api/CargoCompanies - PUT
Body - raw - JSON
```json
{
    "CargoCompanyId":3,
    "CargoCompanyName":"PTT Kargo"
}
```