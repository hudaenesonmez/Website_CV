using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class Context : IdentityDbContext<WriterUser,WriterRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;" +
                "database=CoreProjeDB;integrated security=true");

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Admin rolünü oluştur
            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int>
            {
                Id = 1, // Rol ID'si
                Name = "Admin", // Rol adı
                NormalizedName = "ADMIN" // Normalized rol adı (büyük harfli)
            });

            // Admin kullanıcısını oluştur
            var adminUser = new IdentityUser<int>
            {
                Id = 1, // Kullanıcı ID'si
                UserName = "admin", // Kullanıcı adı
                NormalizedUserName = "ADMIN", // Normalized kullanıcı adı
                Email = "admin@gmail.com", // Admin email
                NormalizedEmail = "ADMIN@GMAIL.COM", // Normalized email
                EmailConfirmed = true // Email doğrulandı
            };

            // Admin kullanıcısı için şifre hashleme
            var hasher = new PasswordHasher<IdentityUser<int>>();
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin11*"); // Admin Şifresini Belirle

            builder.Entity<IdentityUser<int>>().HasData(adminUser);

            // Admin rolünü admin kullanıcıya ata
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                UserId = 1, // Admin kullanıcısının ID'si
                RoleId = 1  // Admin rolünün ID'si
            });
        }



        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portofolio> Portofolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Test1> Test1s { get; set; }
        public DbSet<Announcement> Announcements { get; set; }  
        public DbSet<WriterMessage> WriterMessages { get; set; }
    }
}
