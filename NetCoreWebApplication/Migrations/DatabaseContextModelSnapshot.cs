﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreWebApplication.Data;

#nullable disable

namespace NetCoreWebApplication.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Description = "Elektronik, elektrik kullanarak bilgi işleyen, taşıyan veya depolayan elemanları ve sistemleri inceleyen bilim dalıdır.",
                            Image = "elektronik.png",
                            Name = "Elektronik",
                            ParentId = 1
                        },
                        new
                        {
                            Id = -2,
                            Description = "Her türlü tüketim maddelerinin, özellikle paketlenmiş ya da açık yiyecek maddelerinin, mutfak ve temizlik gereçlerinin vb. satıldığı, alıcının istediği malı kendi eliyle seçerek aldığı büyük mağaza.",
                            Image = "süpermarket.jpg",
                            Name = "SüperMarket",
                            ParentId = 2
                        },
                        new
                        {
                            Id = -3,
                            Description = "Cildi ve saçları güzelleştirmeye, diri tutmaya yarayan her türlü kokulu maddenin ortak adı.",
                            Image = "kozmetik.jpg",
                            Name = "Kozmetik",
                            ParentId = 3
                        });
                });

            modelBuilder.Entity("Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreateDate = new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(1199),
                            Email = "test@test.com",
                            Message = "Lütfen bana dönüş yapınız?",
                            Name = "Sena Şen",
                            Phone = "12345689"
                        },
                        new
                        {
                            Id = -2,
                            CreateDate = new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(1209),
                            Email = "test1@test.com",
                            Message = "Lütfen bana dönüş yapınız?",
                            Name = "Simge Sev",
                            Phone = "321654987"
                        });
                });

            modelBuilder.Entity("Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Content = "Depremde herhangi bir can kaybı ve hasar meydana gelmedi.",
                            CreateDate = new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(2857),
                            Image = "deprem1.jpg",
                            Name = "Bursa’da Deprem"
                        },
                        new
                        {
                            Id = -2,
                            Content = "Teknik donanımını tamamladıktan sonra tam performanslı olarak seri üretime geçebilir.",
                            CreateDate = new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(2865),
                            Image = "araba.jpg",
                            Name = "Sürücüsüz Araba"
                        },
                        new
                        {
                            Id = -3,
                            Content = "Tüm kesim daha önce bilgilendirilmiş gencinden yaşlısına, memurundan işçisine kim varsa orada hazır bulunmuş ve fidan dikimi 1 saat gibi çok kısa sürede dikilmiş oldu.",
                            CreateDate = new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(2871),
                            Image = "zxczxc.jpg",
                            Name = "Ağaç Dikme Rekoru"
                        });
                });

            modelBuilder.Entity("Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Content = "Klavye ya da İngilizce adıyla keyboard, birçok tuşun bir arada yer aldığı ve bilgisayara komut vermek için kullanılan harici donanımdır.",
                            CreateDate = new DateTime(2023, 10, 26, 13, 32, 22, 644, DateTimeKind.Local).AddTicks(9818),
                            Image = "klavye.jpg",
                            Name = "Klavye"
                        },
                        new
                        {
                            Id = -2,
                            Content = "Dizüstü bilgisayarlar bir AC bağdaştırıcıdan gücünü alır ve şarj edilebilir bir batarya ile güç kaynağından uzakta da kullanılabilir. Dizüstü bilgisayarlar küçük ve taşınabilir olmaları açısından avantajlıdır.",
                            CreateDate = new DateTime(2023, 10, 26, 13, 32, 22, 644, DateTimeKind.Local).AddTicks(9833),
                            Image = "laptop.jpg",
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = -3,
                            Content = "Fare, genellikle avuç içinde tutulan, hareketleri bilgisayar ekranındaki imlecin hareketlerini kontrol eden, bilgi giriş aygıtıdır. Fare modeline göre üzerinde bir veya daha fazla sayıda tuş ve tekerlek bulunabilir. İlk bilgisayar faresi 1964 yılında Douglas Engelbart tarafından yapıldı.",
                            CreateDate = new DateTime(2023, 10, 26, 13, 32, 22, 644, DateTimeKind.Local).AddTicks(9840),
                            Image = "fare.jpg",
                            Name = "Fare"
                        });
                });

            modelBuilder.Entity("Entities.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Description = "Güzel bir manzara yalnızlığın en iyi ilacıdır.",
                            Image = "manzaraaaaa.jpg",
                            Link = "https://tr.pinterest.com/bozotuta/manzara-resimleri/",
                            Name = "Manzara Resmi"
                        },
                        new
                        {
                            Id = -2,
                            Description = "Evin penceresinden bakan ile zirveden bakanın manzarası bir olmaz.",
                            Image = "sadsdsa.jpg",
                            Link = "https://tr.pinterest.com/bozotuta/manzara-resimleri/",
                            Name = "Manzara Resmi1"
                        },
                        new
                        {
                            Id = -3,
                            Description = "Eğer güzel bir manzara görürsen ve hareket halindeysen dur ve izle, çünkü o manzara yıllar sonra senin anın olarak mazinde yer alacaktır.",
                            Image = "dasdsad.jpg",
                            Link = "https://tr.pinterest.com/bozotuta/manzara-resimleri/",
                            Name = "Manzara Resmi2"
                        });
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreateDate = new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(4530),
                            Email = "adminNetCoreWebApplication@123.net",
                            IsActive = true,
                            Name = "Simge",
                            Password = "123456",
                            Phone = "123456789",
                            SurName = "Sev",
                            UserName = "SimgeSev"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
