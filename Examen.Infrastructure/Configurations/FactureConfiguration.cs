using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class FactureConfiguration : IEntityTypeConfiguration<Facture>
    {
        public void Configure(EntityTypeBuilder<Facture> builder)
        {
            builder.HasKey(fac => new { fac.ProduitId, fac.FournisseurId });
            // builder.
            //.............
        }
    }
}
