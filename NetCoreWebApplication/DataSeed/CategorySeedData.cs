using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NetCoreWebApplication.DataSeed
{
    public class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
                 (
                     new Category { Id = -1, ParentId =1, Name = "Elektronik" ,Description= "Elektronik, elektrik kullanarak bilgi işleyen, taşıyan veya depolayan elemanları ve sistemleri inceleyen bilim dalıdır." ,Image= "elektronik.png" },
                     new Category { Id = -2, ParentId = 2, Name = "SüperMarket" ,Description= "Her türlü tüketim maddelerinin, özellikle paketlenmiş ya da açık yiyecek maddelerinin, mutfak ve temizlik gereçlerinin vb. satıldığı, alıcının istediği malı kendi eliyle seçerek aldığı büyük mağaza." ,Image= "süpermarket.jpg" },
                     new Category { Id = -3, ParentId =3, Name = "Kozmetik" ,Description= "Cildi ve saçları güzelleştirmeye, diri tutmaya yarayan her türlü kokulu maddenin ortak adı.",Image= "kozmetik.jpg" }
                   
                 );
        }
    }
}
