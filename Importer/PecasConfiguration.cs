using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Importer
{
    public class PecasConfiguration : IEntityTypeConfiguration<PecaModel>
    {
        public void Configure(EntityTypeBuilder<PecaModel> builder)
        {
            builder.ToTable("pecas_nova");
            builder.HasKey(x => x.ID);

        }
    }
}

