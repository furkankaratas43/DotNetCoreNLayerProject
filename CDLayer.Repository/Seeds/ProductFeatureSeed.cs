using CDLayer.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDLayer.Repository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {

            builder.HasData(
                new ProductFeature
                {
                    Id = 1,
                    Color = "Kırmızı",
                    Height = 200,
                    Width = 100,
                    ProductId = 1
                },
                new ProductFeature
                {
                    Id = 2,
                    Color = "Mavi",
                    Height = 200,
                    Width = 100,
                    ProductId = 2
                }
            );
        }
    }
}
