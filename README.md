# ASP.NET Core MVC - E-Commerce Tutorial

ASP.NET Core MVC ve Entity Framework Core teknolojilerini uygulamalı olarak öğrenmek, MVC mimarisini ve veritabanı işlemlerini pekiştirmek amacıyla geliştirdiğim e-ticaret temalı örnek projedir.

Proje, temel bir ürün ve kategori yapısı üzerinden MVC mimarisinin çalışma prensiplerini, veritabanı ilişkilerini, veri sorgulama işlemlerini ve Razor View kullanımını ele almaktadır.

> **Not:** Bu repository geliştirme ve öğrenme sürecini içermektedir. Tamamlanmış veya production-ready bir e-ticaret uygulaması değildir.

## Kullanılan Teknolojiler

- **.NET 10 / ASP.NET Core MVC**
- **C#**
- **Entity Framework Core 10**
- **SQLite**
- **Razor View Engine**
- **LINQ**
- **HTML / CSS**

## Projede Ele Alınan Konular

### ASP.NET Core MVC

- Model, View ve Controller yapısı
- Controller ve Action metotları
- Routing ve özel route tanımlamaları
- Razor View kullanımı
- ViewData ile veri aktarımı
- ViewComponent yapısı

### Entity Framework Core

- Code First yaklaşımı
- `DbContext` ve `DbSet` kullanımı
- Dependency Injection ile DbContext yönetimi
- Migration oluşturma ve veritabanını güncelleme
- `OnModelCreating()` ile Seed Data tanımlama
- Entity ilişkileri (Product - Category)
- LINQ ile veritabanı sorguları

### Ürün ve Kategori İşlemleri

- Ürünlerin veritabanından listelenmesi
- Ürün detaylarının görüntülenmesi
- Kategoriye göre ürün filtreleme
- Ürün adına göre arama
- Aktif ürünlerin listelenmesi
- Ana sayfada gösterilecek ürünlerin belirlenmesi

## Geliştirme Notları (Notes.md)

Bu repository yalnızca kaynak kodlardan oluşmamaktadır. Öğrenme sürecinde karşılaştığım kavramları, önemli komutları ve MVC'nin çalışma prensiplerini kendi açıklamalarımla belgelediğim bir not dosyası da içermektedir.

**[Notes.md dosyasını inceleyin](./Notes.md)**

Not dosyasında şu konulara değinilmektedir:

- Entity Framework Core Migration işlemleri ve terminal komutları
- Veritabanı güncelleme süreci
- Request Model ve Entity arasındaki veri aktarımı
- `SaveChanges()` ile verilerin kaydedilmesi
- `RedirectToAction()` kullanımı
- `ViewData` ve `TempData` arasındaki yaşam süresi farkları

Bu dosya, proje geliştikçe öğrendiğim yeni kavramları ve karşılaştığım problemleri belgelemek amacıyla güncellenebilir.

## Proje Yapısı

```text
dotnet-mvc-ecommerce/
├── Context/          # EF Core DbContext ve Seed Data
├── Controllers/      # MVC Controller sınıfları
├── Entities/         # Veritabanı entity sınıfları
├── Migrations/       # EF Core Migration dosyaları
├── Models/           # Uygulama modelleri
├── ViewComponents/   # Yeniden kullanılabilir View bileşenleri
├── Views/            # Razor View dosyaları
├── wwwroot/          # Statik dosyalar
├── Program.cs        # Servis ve uygulama yapılandırması
├── appsettings.json  # Uygulama ve veritabanı ayarları
├── store.db          # SQLite veritabanı
└── Notes.md          # Geliştirme ve öğrenme notları
```

## Kurulum ve Çalıştırma

Projeyi çalıştırabilmek için **.NET 10 SDK** kurulu olmalıdır.

**1. Repository'yi klonlayın:**

```bash
git clone https://github.com/abdullahTaha050/dotnet-mvc-ecommerce.git
cd dotnet-mvc-ecommerce
```

**2. NuGet bağımlılıklarını yükleyin:**

```bash
dotnet restore
```

**3. Projeyi derleyin:**

```bash
dotnet build
```

**4. Uygulamayı çalıştırın:**

```bash
dotnet run
```

Uygulama başladıktan sonra terminalde belirtilen localhost adresi üzerinden erişebilirsiniz.

### Veritabanı

Projede SQLite kullanılmaktadır. Veritabanı bağlantı bilgisi `appsettings.json` içerisinde tanımlanmıştır.

Veritabanını mevcut Migration dosyaları üzerinden yeniden oluşturmak veya güncellemek için:

```bash
dotnet ef database update
```

Bu komut için `dotnet-ef` aracının kurulu olması gerekir.

Migration ve veritabanı yönetimine ilişkin ek açıklamalar için [Notes.md](./Notes.md) dosyasına bakabilirsiniz.

## Projenin Amacı

Bu projedeki temel amacım, mevcut backend geliştirme bilgilerimi ASP.NET Core MVC mimarisiyle birleştirerek framework'ün sunduğu yapıları uygulamalı olarak deneyimlemek.

Özellikle Entity Framework Core, Razor, MVC request-response akışı, form işlemleri ve veritabanı yönetimi gibi konular üzerinde çalışıyorum.

Proje, öğrenme süreci boyunca yeni örnekler ve geliştirmelerle genişletilecektir.

---

**Geliştirici:** [Abdullah Taha Aksakal](https://github.com/abdullahTaha050)
