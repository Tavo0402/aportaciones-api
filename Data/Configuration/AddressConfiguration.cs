using Aportaciones.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aportaciones.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            string[,] streets = new string[12, 3] { { "Paseo Del Opalo", "10700" ,"10800"},
                                                    { "Paseo Del Topacio","10700" ,"10800"},
                                                    { "Paseo Del Onix","10700" ,"10800"},
                                                    { "Paseo Del Oro", "10700" ,"10800"},
                                                    { "Paseo De La Plata", "10700" ,"10800"},
                                                    { "Paseo Del Zirconio", "10700" ,"10800"},
                                                    { "Paseo Del Rubi", "10700" ,"10800"},
                                                    { "Paseo Del Jade", "10700" ,"10800"},
                                                    { "Paseo De La Esmeralda", "10700" ,"10800"},
                                                    { "Paseo Del Zafiro", "10700" ,"10800"},
                                                    { "Paseo De La Amatista","10700" ,"10800"},
                                                    { "Paseo De La Perla","10700","10800" } };

            builder.ToTable("Address");
            var id = 1;

            for (int i = 0; i < streets.GetLength(0); i++)
            {
                for (int j = int.Parse(streets[i, 1]); j <= int.Parse(streets[i, 2]); j++)
                {
                    builder.HasData(new Address
                    {
                        Id = id,
                        Street = streets[i, 0],
                        Number = j,
                        Email = "",
                        Name = ""
                    });
                    id++;
                }
            }
        }
    }
}
