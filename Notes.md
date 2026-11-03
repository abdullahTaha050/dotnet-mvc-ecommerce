- Dotnet EF aracı ile terminal üzerinden migration oluşturma komutu:

``dotnet ef migrations add InitialCreate``

İLK ADIM OLARAK ``dotnet build`` komutu çalıştırılmalıdır. ondan sonra migration oluşturma yapılmalıdır.

- Migrationlar oluştuktan sonra ``dotnet ef database update`` komutu çalıştırılır. 
Böylece oluşturulan migrationlar database'e gönderilir.

- Rest Api modelindeki gibi Request modelleri oluşturulup daha sonra entity'e map edilir ve db'ye o şekilde kaydedilir.
- DB bağlantısını EF hallediyor. DB ye kayıt eklendikten sonra save ile işlem tamamlanır. Commit ediyor yani.

- ``return RedirectToAction("Index")`` ifadesi örneğin bir insert işleminden sonra, kullanıcıyı başka bir sayfaya,
örn. listeleme sayfasına yönlendirmek için kullanılır.

- RedirectToAction kullanıldığı zaman, View Değişeceği için ViewData'ya ulaşmak mümkün olmaz. Bu durumda TempData kullanılabilir. Peki neden? örn. kullanıcı bir veri ekledi ve anasayfaya yönlendirdik. orada da bir mesaj göstermek istiyoruz. bunu tempdata ile yapabiliriz, çünkü viewData mevcut view değiştiği için boş olacaktır.

