using Aportaciones.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aportaciones.Data.Configuration
{
    public class InputConfiguration : IEntityTypeConfiguration<Input>
    {
        public void Configure(EntityTypeBuilder<Input> builder)
        {
            int[] years = new int[5] { 2019, 2020, 2021, 2022, 2023 };
            var today = DateTime.Now;
            var isActive = false;
            var id = 1;

            builder.ToTable("Inputs");

            for (int i = 0; i < years.Length; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    var month = j < 10 ? $"0{j}" : j.ToString();
                    if (today.Month == j && today.Year == years[i]) { isActive = true; }

                    builder.HasData(new Input
                    {
                        Id = id,
                        Month = j,
                        Year = years[i],
                        StartDate = DateTime.Parse($"{month}/15/{years[i]}"),
                        EndDate = DateTime.Parse($"{month}/17/{years[i]}"),
                        IsActive = isActive
                    });

                    id++;
                    isActive = false;
                }
            }
        }
    }
}
