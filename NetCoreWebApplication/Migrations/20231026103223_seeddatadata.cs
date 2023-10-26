using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NetCoreWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class seeddatadata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Image", "Name", "ParentId" },
                values: new object[,]
                {
                    { -3, "Cildi ve saçları güzelleştirmeye, diri tutmaya yarayan her türlü kokulu maddenin ortak adı.", "kozmetik.jpg", "Kozmetik", 3 },
                    { -2, "Her türlü tüketim maddelerinin, özellikle paketlenmiş ya da açık yiyecek maddelerinin, mutfak ve temizlik gereçlerinin vb. satıldığı, alıcının istediği malı kendi eliyle seçerek aldığı büyük mağaza.", "süpermarket.jpg", "SüperMarket", 2 },
                    { -1, "Elektronik, elektrik kullanarak bilgi işleyen, taşıyan veya depolayan elemanları ve sistemleri inceleyen bilim dalıdır.", "elektronik.png", "Elektronik", 1 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreateDate", "Email", "Message", "Name", "Phone" },
                values: new object[,]
                {
                    { -2, new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(1209), "test1@test.com", "Lütfen bana dönüş yapınız?", "Simge Sev", "321654987" },
                    { -1, new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(1199), "test@test.com", "Lütfen bana dönüş yapınız?", "Sena Şen", "12345689" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Content", "CreateDate", "Image", "Name" },
                values: new object[,]
                {
                    { -3, "Tüm kesim daha önce bilgilendirilmiş gencinden yaşlısına, memurundan işçisine kim varsa orada hazır bulunmuş ve fidan dikimi 1 saat gibi çok kısa sürede dikilmiş oldu.", new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(2871), "zxczxc.jpg", "Ağaç Dikme Rekoru" },
                    { -2, "Teknik donanımını tamamladıktan sonra tam performanslı olarak seri üretime geçebilir.", new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(2865), "araba.jpg", "Sürücüsüz Araba" },
                    { -1, "Depremde herhangi bir can kaybı ve hasar meydana gelmedi.", new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(2857), "deprem1.jpg", "Bursa’da Deprem" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreateDate", "Image", "Name" },
                values: new object[,]
                {
                    { -3, "Fare, genellikle avuç içinde tutulan, hareketleri bilgisayar ekranındaki imlecin hareketlerini kontrol eden, bilgi giriş aygıtıdır. Fare modeline göre üzerinde bir veya daha fazla sayıda tuş ve tekerlek bulunabilir. İlk bilgisayar faresi 1964 yılında Douglas Engelbart tarafından yapıldı.", new DateTime(2023, 10, 26, 13, 32, 22, 644, DateTimeKind.Local).AddTicks(9840), "fare.jpg", "Fare" },
                    { -2, "Dizüstü bilgisayarlar bir AC bağdaştırıcıdan gücünü alır ve şarj edilebilir bir batarya ile güç kaynağından uzakta da kullanılabilir. Dizüstü bilgisayarlar küçük ve taşınabilir olmaları açısından avantajlıdır.", new DateTime(2023, 10, 26, 13, 32, 22, 644, DateTimeKind.Local).AddTicks(9833), "laptop.jpg", "Laptop" },
                    { -1, "Klavye ya da İngilizce adıyla keyboard, birçok tuşun bir arada yer aldığı ve bilgisayara komut vermek için kullanılan harici donanımdır.", new DateTime(2023, 10, 26, 13, 32, 22, 644, DateTimeKind.Local).AddTicks(9818), "klavye.jpg", "Klavye" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Description", "Image", "Link", "Name" },
                values: new object[,]
                {
                    { -3, "Eğer güzel bir manzara görürsen ve hareket halindeysen dur ve izle, çünkü o manzara yıllar sonra senin anın olarak mazinde yer alacaktır.", "dasdsad.jpg", "https://tr.pinterest.com/bozotuta/manzara-resimleri/", "Manzara Resmi2" },
                    { -2, "Evin penceresinden bakan ile zirveden bakanın manzarası bir olmaz.", "sadsdsa.jpg", "https://tr.pinterest.com/bozotuta/manzara-resimleri/", "Manzara Resmi1" },
                    { -1, "Güzel bir manzara yalnızlığın en iyi ilacıdır.", "manzaraaaaa.jpg", "https://tr.pinterest.com/bozotuta/manzara-resimleri/", "Manzara Resmi" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "Email", "IsActive", "Name", "Password", "Phone", "SurName", "UserName" },
                values: new object[] { -1, new DateTime(2023, 10, 26, 13, 32, 22, 645, DateTimeKind.Local).AddTicks(4530), "adminNetCoreWebApplication@123.net", true, "Simge", "123456", "123456789", "Sev", "SimgeSev" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "Email", "IsActive", "Name", "Password", "Phone", "SurName", "UserName" },
                values: new object[] { 1, new DateTime(2023, 10, 24, 21, 51, 9, 246, DateTimeKind.Local).AddTicks(9413), "adminNetCoreWebApplication.net", true, "Admin", "123456", "123456789", "admin12", "Admin" });
        }
    }
}
