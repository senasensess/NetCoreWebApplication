using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NetCoreWebApplication.DataSeed
{
    public class UserSeedData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
                (
                    new User { Id = -1, Name = "Simge", SurName = "Sev", UserName= "SimgeSev" ,Password="123456",Email= "adminNetCoreWebApplication@123.net" ,Phone= "123456789",IsActive=true ,CreateDate=DateTime.Now}
               

                );
        }
    }
}
