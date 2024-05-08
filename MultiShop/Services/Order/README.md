# Docker

[Download](https://www.docker.com/products/docker-desktop/) Docker -> Download for Windows.

## Portainer
```bash
PS > docker volume create portainer_data

PS > docker run -d -p 8000:8000 -p 9000:9000 --name=portainer --restart=always -v /var/run/docker.sock:/var/run/docker.sock -v portainer_data:/data portainer/portainer-ce
```

```cs
http://localhost:9000/
Username : admin
Password : Aa123456789+
```

```bash
App Templates
SQL Server - linux container

1.
Name     : OrderDb
Password : Aa123456+ 
+ Hide advanced options
- Published Ports
host : 1440 
container : 1433
-------------------------------
2.
Name     : IdentityDb
Password : Aa123456+ 
+ Hide advanced options
- Published Ports
host : 1433 
container : 1433

> Deploy the container
```

# DBeaver

[Download](https://dbeaver.io/download/) DBeaver -> Windows (installer).

```
SQL Server - port 1433
Username : sa
Password : Aa123456+
```