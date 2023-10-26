using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NetCoreWebApplication.DataSeed
{
    public class SliderSeedData : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.HasData
                (
                    new Slider { Id = -1, Name = "Manzara Resmi",Description= "Güzel bir manzara yalnızlığın en iyi ilacıdır." ,Link= "https://tr.pinterest.com/bozotuta/manzara-resimleri/",Image= "manzaraaaaa.jpg" },
                    new Slider { Id = -2, Name = "Manzara Resmi1",Description= "Evin penceresinden bakan ile zirveden bakanın manzarası bir olmaz.", Link= "https://tr.pinterest.com/bozotuta/manzara-resimleri/" ,Image= "sadsdsa.jpg" },
                     new Slider { Id = -3, Name = "Manzara Resmi2",Description= "Eğer güzel bir manzara görürsen ve hareket halindeysen dur ve izle, çünkü o manzara yıllar sonra senin anın olarak mazinde yer alacaktır." ,Link= "https://tr.pinterest.com/bozotuta/manzara-resimleri/" ,Image= "dasdsad.jpg" }

                );
        }
    }
}
