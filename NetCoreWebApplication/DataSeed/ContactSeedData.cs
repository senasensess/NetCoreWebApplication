using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NetCoreWebApplication.DataSeed
{
    public class ContactSeedData : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasData
                (
                    new Contact { Id = -1, Name = "Sena Şen", Email= "test@test.com" ,Phone="12345689" ,Message="Lütfen bana dönüş yapınız?",CreateDate=DateTime.Now },
                    new Contact { Id = -2, Name = "Simge Sev",Email= "test1@test.com",Phone="321654987" , Message = "Lütfen bana dönüş yapınız?" , CreateDate = DateTime.Now }
                  

                );
        }
    }
}
