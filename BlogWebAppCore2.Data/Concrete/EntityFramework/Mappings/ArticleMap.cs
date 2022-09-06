using BlogWebAppCore2.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAppCore2.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id); // Primary key
            builder.Property(a => a.Id).ValueGeneratedOnAdd(); // Identity column
            builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Content).IsRequired().HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired().HasMaxLength(50);
            builder.Property(a => a.SeoDescription).IsRequired().HasMaxLength(150);
            builder.Property(a => a.SeoTags).IsRequired().HasMaxLength(70);
            builder.Property(a => a.ViewsCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired().HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne(a => a.Category)
                   .WithMany(c => c.Articles)
                   .HasForeignKey(a => a.CategoryId);
            builder.HasOne(a => a.User)
                   .WithMany(u => u.Articles)
                   .HasForeignKey(a => a.UserId);
            builder.ToTable("Articles"); // Table name
            builder.HasData(new Article
            {
                Id = 1,
                CategoryId = 1,
                Title = "C# 10.0 və .NET 6 yenilikləri",
                Content = "NET 6 delivers the final parts of the .NET unification plan that started with .NET 5. .NET 6 unifies the SDK, base libraries, and runtime across mobile, desktop, IoT, and cloud apps. In addition to this unification, the .NET 6 ecosystem offers:Simplified development: Getting started is easy. New language features in C# 10 reduce the amount of code you need to write. And investments in the web stack and minimal APIs make it easy to quickly write smaller, faster microservices.Better performance: .NET 6 is the fastest full stack web framework, which lowers compute costs if you're running in the cloud.Ultimate productivity: .NET 6 and Visual Studio 2022 provide hot reload, new git tooling, intelligent code editing, robust diagnostics and testing tools, and better team collaboration..NET 6 will be supported for three years as a long-term support (LTS) release.Preview features are disabled by default. They are also not supported for use in production and may be removed in a future version. The new RequiresPreviewFeaturesAttribute is used to annotate preview APIs, and a corresponding analyzer alerts you if you're using these preview APIs..NET 6 is supported by Visual Studio 2022 and Visual Studio 2022 for Mac (and later versions).This article does not cover all of the new features of .NET 6. To see all of the new features, and for further information about the features listed in this article, see the Announcing .NET 6 blog post.",
                Thumbnail = "Default.jpg",
                SeoDescription = "C# 10.0 və .NET 6 yenilikləri",
                SeoTags = "C#, C# 10, .NET6, .NET Core",
                SeoAuthor = "Kenan Idayatov",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# 10.0 və .NET 6 yenilikləri",
                UserId = 1,
                ViewsCount = 340,
                CommentCount = 1
            },
            new Article
            {
                Id = 2,
                CategoryId = 2,
                Title = "C++ 11 və 19 yenilikləri",
                Content = "In 1979, Bjarne Stroustrup, a Danish computer scientist, began work on \"C with Classes\", the predecessor to C++.[17] The motivation for creating a new language originated from Stroustrup's experience in programming for his PhD thesis. Stroustrup found that Simula had features that were very helpful for large software development, but the language was too slow for practical use, while BCPL was fast but too low-level to be suitable for large software development. When Stroustrup started working in AT&T Bell Labs, he had the problem of analyzing the UNIX kernel with respect to distributed computing. Remembering his PhD experience, Stroustrup set out to enhance the C language with Simula-like features.[18] C was chosen because it was general-purpose, fast, portable and widely used. As well as C and Simula's influences, other languages also influenced this new language, including ALGOL 68, Ada, CLU and ML.",
                Thumbnail = "Default.jpg",
                SeoDescription = "C++ 11 və 19 yenilikləri",
                SeoTags = "C++ 11 və 19 yenilikləri",
                SeoAuthor = "Kenan Idayatov",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C++ 11 və 19 yenilikləri",
                UserId = 1,
                ViewsCount = 100,
                CommentCount = 1
            },
            new Article
            {
                Id = 3,
                CategoryId = 3,
                Title = "JavaScript ES2020 yenilikləri",
                Content = "JavaScript (/ˈdʒɑːvəskrɪpt/),[10] often abbreviated JS, is a programming language that is one of the core technologies of the World Wide Web, alongside HTML and CSS.[11] As of 2022, 98% of websites use JavaScript on the client side for webpage behavior,[12] often incorporating third-party libraries.[13] All major web browsers have a dedicated JavaScript engine to execute the code on users' devices.JavaScript is a high-level, often just-in-time compiled language that conforms to the ECMAScript standard.[14] It has dynamic typing, prototype-based object-orientation, and first-class functions. It is multi-paradigm, supporting event-driven, functional, and imperative programming styles. It has application programming interfaces (APIs) for working with text, dates, regular expressions, standard data structures, and the Document Object Model (DOM).The ECMAScript standard does not include any input/output (I/O), such as networking, storage, or graphics facilities. In practice, the web browser or other runtime system provides JavaScript APIs for I/O.\r\n\r\nJavaScript engines were originally used only in web browsers, but are now core components of some servers and a variety of applications. The most popular runtime system for this usage is Node.js.",
                Thumbnail = "Default.jpg",
                SeoDescription = "JavaScript ES2020 yenilikləri",
                SeoTags = "JavaScript ES2020 yenilikləri",
                SeoAuthor = "Kenan Idayatov",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# 10.0 və .NET 6 yenilikləri",
                UserId = 1,
                ViewsCount = 12,
                CommentCount = 1
            });
        }
    }
}
