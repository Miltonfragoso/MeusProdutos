using DevIO.Business.Models.Fornecedores;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;


namespace DevIO.Infra.Data.Mappings
{
    public class FornecedorConfig : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfig() 
        {
            //  Mapeamento de chave primaria
            HasKey(f => f.Id);


            //  Mapeamento de propiedades
            Property(f => f.Nome)
                    .IsRequired()
                    .HasMaxLength(200);

            //  Mapeamento de propiedade e index de banco de dados 
            Property(f => f.Documento)
                   .IsRequired()
                   .HasMaxLength(14)
                   .HasColumnAnnotation("IX_Documento", new IndexAnnotation(new IndexAttribute { IsUnique = true }));


            //  Mapeamento de 1 para 1 
            HasRequired(f => f.Endereco)
                   .WithRequiredPrincipal(e => e.Fornecedor);

            // Nome da tabela
            ToTable("Fornecedores");
        }
    }
}
