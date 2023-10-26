using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NetCoreWebApplication.DataSeed
{
    public class NewSeedData : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasData
                 (
                     new News { Id = -1, Name = "Bursa’da Deprem", Content = "Depremde herhangi bir can kaybı ve hasar meydana gelmedi.",Image= "deprem1.jpg", CreateDate = DateTime.Now },
                     new News { Id = -2, Name = "Sürücüsüz Araba", Content = "Teknik donanımını tamamladıktan sonra tam performanslı olarak seri üretime geçebilir.",Image= "araba.jpg" , CreateDate = DateTime.Now },
                     new News { Id = -3, Name = "Ağaç Dikme Rekoru", Content = "Tüm kesim daha önce bilgilendirilmiş gencinden yaşlısına, memurundan işçisine kim varsa orada hazır bulunmuş ve fidan dikimi 1 saat gibi çok kısa sürede dikilmiş oldu.",Image= "zxczxc.jpg" ,CreateDate=DateTime.Now }

                 );
        }
    }
}
