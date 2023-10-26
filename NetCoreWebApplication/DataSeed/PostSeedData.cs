using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NetCoreWebApplication.DataSeed
{
    public class PostSeedData : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {

            builder.HasData
                (
                    new Post { Id = -1, Name = "Klavye",Content= "Klavye ya da İngilizce adıyla keyboard, birçok tuşun bir arada yer aldığı ve bilgisayara komut vermek için kullanılan harici donanımdır.",Image= "klavye.jpg" ,CreateDate=DateTime.Now},
                    new Post { Id = -2, Name = "Laptop",Content= "Dizüstü bilgisayarlar bir AC bağdaştırıcıdan gücünü alır ve şarj edilebilir bir batarya ile güç kaynağından uzakta da kullanılabilir. Dizüstü bilgisayarlar küçük ve taşınabilir olmaları açısından avantajlıdır.",Image= "laptop.jpg", CreateDate = DateTime.Now },
                    new Post { Id = -3, Name = "Fare",Content= "Fare, genellikle avuç içinde tutulan, hareketleri bilgisayar ekranındaki imlecin hareketlerini kontrol eden, bilgi giriş aygıtıdır. Fare modeline göre üzerinde bir veya daha fazla sayıda tuş ve tekerlek bulunabilir. İlk bilgisayar faresi 1964 yılında Douglas Engelbart tarafından yapıldı.",Image= "fare.jpg" , CreateDate = DateTime.Now }



                );
        }
    }
}
