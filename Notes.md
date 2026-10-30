- Dotnet EF aracı ile terminal üzerinden migration oluşturma komutu:

``dotnet ef migrations add InitialCreate``

İLK ADIM OLARAK ``dotnet build`` komutu çalıştırılmalıdır. ondan sonra migration oluşturma yapılmalıdır.

- Migrationlar oluştuktan sonra ``dotnet ef database update`` komutu çalıştırılır. 
Böylece oluşturulan migrationlar database'e gönderilir.