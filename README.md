# Personal CV Website with Admin & User Panel

This project is a personal CV website that allows users to contact me and leave references or feedback. Additionally, as the admin, I can respond to these interactions through a dedicated admin panel. The site showcases my skills, experiences, and projects in a user-friendly interface.

## Technologies Used

### 1. **ASP.NET Core 5.0**

ASP.NET Core 5.0 is the main framework used to develop this project. It provides a powerful and flexible platform for building dynamic web applications, and its modular nature allows for efficient integration with other technologies.

### 2. **Fluent Validation**

Fluent Validation is a .NET library used for implementing validation rules in a fluent and readable way. It is especially useful in form submissions and user input validation.

### 3. **Identity**

ASP.NET Core Identity is a library used to manage user authentication and authorization. It is integrated into the project to allow for user login, registration, and role management.

### 4. **Entity Framework Core (EF Core)**

Entity Framework Core is an Object-Relational Mapping (ORM) framework that enables database interaction using .NET objects. It is used in this project to interact with the underlying SQL database.

### 5. **MSSQL**

Microsoft SQL Server (MSSQL) is used as the database management system for storing all project data. The application communicates with MSSQL using Entity Framework Core for performing CRUD operations.

### 6. **Ajax**

Ajax (Asynchronous JavaScript and XML) is a technology used to send and receive data asynchronously from the server without reloading the entire page. This allows for a dynamic and smooth user experience.

## Project Features

- **Personal CV**: The website contains all relevant personal information, skills, and work experience in a well-organized format.
- **User Panel**: Users can contact me through a form and leave feedback or references.
- **Admin Panel**: As the admin, I can view messages, respond to inquiries, and manage the content of the website.

### 1. CRUD Operations

- Manage all content (About, References, Highlights, Projects) from the admin panel.
- Add, edit, or delete entries dynamically.
- Keep the website content up-to-date with ease.

### 2. Messaging System

- Users can send messages through the website.
- The admin can view and respond to these messages directly from the admin panel.

### 3. References and Feedback

- Users can leave references or feedback via the website.
- The admin can review and respond to these inputs if necessary.

### 4. Announcements

- Create announcements in the admin panel to share with users.
- Announcements appear on the homepage or a dedicated section for easy access.

### 5. About and Highlights

- The "About" section displays personal information, skills, and career goals.
- The "Highlights" section emphasizes key achievements and projects.

### 6. Projects

- Showcase projects with detailed descriptions and visuals.
- Manage projects (add, edit, delete) from the admin panel.

---

## Usage Scenarios

- **Admin Panel**:

  - Manage references and feedback.
  - Respond to user messages.
  - Add/edit/delete projects.
  - Share announcements.

- **User Interface**:
  - View personal information and projects.
  - Send messages and leave feedback.

---

## Database Configuration

- In the **Context** folder, you will find the SQL database settings that can be adjusted to match your own database configuration.
- The application is set up to automatically create the database and add an admin user by default when running for the first time.

## Development Status

The development of the project is mostly complete, with further improvements and updates planned in the upcoming weeks. The project will continue to be enhanced and updated regularly.

## Future Plans

- This project will soon be deployed to a live website with a custom domain.
- The site will be publicly available for users to view and interact with.

# Kişisel CV Websitesi - Admin ve Kullanıcı Paneli

Bu proje, kullanıcıların benimle iletişime geçebilmesi ve referans veya geri bildirim bırakabilmesi için bir kişisel CV web sitesidir. Ayrıca, admin olarak, bu etkileşimlere yanıt verebileceğim özel bir admin paneli de bulunmaktadır. Site, yeteneklerimi, deneyimlerimi ve projelerimi kullanıcı dostu bir arayüzle sergilemektedir.

## Kullanılan Teknolojiler

### 1. **ASP.NET Core 5.0**

ASP.NET Core 5.0, bu projenin geliştirilmesinde kullanılan ana framework'tür. Dinamik web uygulamaları oluşturmak için güçlü ve esnek bir platform sunar ve modüler yapısı sayesinde diğer teknolojilerle verimli entegrasyon sağlar.

### 2. **Fluent Validation**

Fluent Validation, doğrulama kurallarını akıcı ve okunabilir bir şekilde uygulamak için kullanılan bir .NET kütüphanesidir. Özellikle form gönderileri ve kullanıcı girdi doğrulamaları için faydalıdır.

### 3. **Identity**

ASP.NET Core Identity, kullanıcı kimlik doğrulama ve yetkilendirme işlemlerini yönetmek için kullanılan bir kütüphanedir. Bu proje ile entegre edilerek kullanıcı giriş, kayıt ve rol yönetimi sağlanmıştır.

### 4. **Entity Framework Core (EF Core)**

Entity Framework Core, veritabanı ile etkileşimde bulunmak için .NET nesneleri kullanan bir Nesne-İlişkisel Eşleme (ORM) framework'üdür. Bu projede, CRUD işlemleri gerçekleştirmek için EF Core kullanılmıştır.

### 5. **MSSQL**

Microsoft SQL Server (MSSQL), proje verilerinin saklandığı veritabanı yönetim sistemidir. Uygulama, MSSQL ile iletişim kurarak veritabanı işlemlerini gerçekleştiren Entity Framework Core kullanır.

### 6. **Ajax**

Ajax (Asenkron JavaScript ve XML), sunucudan veri göndermek ve almak için kullanılan bir teknolojidir. Sayfanın tamamı yenilenmeden veri iletimi yapılır, bu da dinamik ve akıcı bir kullanıcı deneyimi sağlar.

## Proje Özellikleri

- **Kişisel CV**: Web sitesi, kişisel bilgilerimi, yeteneklerimi ve iş deneyimlerimi düzenli bir formatta içermektedir.
- **Kullanıcı Paneli**: Kullanıcılar, bir form aracılığıyla benimle iletişime geçebilir ve geri bildirim veya referans bırakabilirler.
- **Admin Paneli**: Admin olarak, gelen mesajları görüntüleyebilir, soruları yanıtlayabilir ve site içeriğini yönetebilirim.

### 1. CRUD İşlemleri

- Tüm içerikler (Hakkımda, Referanslar, Öne Çıkanlar, Projeler) yönetici panelinden yönetilebilir.
- Dinamik olarak içerik ekleyebilir, düzenleyebilir veya silebilirsiniz.
- Web sitesinin içeriğini kolayca güncel tutabilirsiniz.

### 2. Mesajlaşma Sistemi

- Kullanıcılar, site üzerinden mesaj göndererek iletişim kurabilir.
- Yönetici, gelen mesajları görüntüleyebilir ve yönetim paneli üzerinden yanıtlayabilir.

### 3. Referans ve Geri Bildirimler

- Kullanıcılar, site üzerinden referans veya geri bildirim bırakabilir.
- Yönetici, bu geri bildirimleri inceleyebilir ve gerekirse yanıtlayabilir.

### 4. Duyurular

- Kullanıcılarla paylaşmak için yönetici panelinde duyurular oluşturabilirsiniz.
- Duyurular, ana sayfada veya belirli bir alanda kolayca erişilebilir şekilde görüntülenir.

### 5. Hakkımda ve Öne Çıkanlar

- "Hakkımda" bölümü, kişisel bilgilerimi, becerilerimi ve kariyer hedeflerimi içerir.
- "Öne Çıkanlar" bölümü, önemli başarılarımı ve projelerimi vurgular.

### 6. Projeler

- Projelerinizi detaylı açıklamalar ve görsellerle sergileyin.
- Yönetici paneli üzerinden projeleri yönetin (ekle, düzenle, sil).

---

## Kullanım Senaryoları

- **Yönetici Paneli**:

  - Referans ve geri bildirimleri yönetin.
  - Kullanıcı mesajlarına yanıt verin.
  - Projeleri ekleyin/düzenleyin/silin.
  - Duyurular paylaşın.

- **Kullanıcı Arayüzü**:
  - Kişisel bilgileri ve projeleri görüntüleyin.
  - Mesaj gönderin ve geri bildirim bırakın.

---

## Veritabanı Yapılandırması

- **Context** klasöründe, kendi veritabanı yapılandırmanıza göre ayarlamalar yapabileceğiniz SQL veritabanı ayarlarını bulabilirsiniz.
- Uygulama, ilk kez çalıştırıldığında veritabanını otomatik olarak oluşturacak ve varsayılan olarak bir admin kullanıcısı ekleyecektir.

## Geliştirme Durumu

Projenin geliştirilmesi çoğunlukla tamamlanmış olup, ilerleyen haftalarda iyileştirmeler ve güncellemeler yapılması planlanmaktadır. Proje, düzenli olarak geliştirilmeye ve güncellenmeye devam edecektir.

## Gelecek Planları

- Bu proje yakında canlı bir web sitesine taşınacak ve özel bir domain ile yayınlanacaktır.
- Site, kullanıcılar tarafından görüntülenebilir ve etkileşimde bulunulabilir olacak.
