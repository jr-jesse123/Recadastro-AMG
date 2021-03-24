using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RecadastroAMG.Web
{
    public partial class AMGContext : DbContext
    {
        public AMGContext()
        {
        }

        public AMGContext(DbContextOptions<AMGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DadosIniciai> DadosIniciais { get; set; }
        public virtual DbSet<DadosIniciais2> DadosIniciais2s { get; set; }
        public virtual DbSet<DadosNormalizado> DadosNormalizados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AMG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DadosIniciai>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AnoFormatura)
                    .HasColumnType("text")
                    .HasColumnName("anoFormatura");

                entity.Property(e => e.Bairro)
                    .HasColumnType("text")
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .HasColumnType("text")
                    .HasColumnName("cep");

                entity.Property(e => e.Cidade)
                    .HasColumnType("text")
                    .HasColumnName("cidade");

                entity.Property(e => e.Complemento)
                    .HasColumnType("text")
                    .HasColumnName("complemento");

                entity.Property(e => e.Cpf)
                    .HasColumnType("text")
                    .HasColumnName("cpf");

                entity.Property(e => e.Crm)
                    .HasColumnName("crm");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("text")
                    .HasColumnName("dataNascimento");

                entity.Property(e => e.Email)
                    .HasColumnType("text")
                    .HasColumnName("email");

                entity.Property(e => e.Estado).HasColumnType("text");

                entity.Property(e => e.Logradoutro)
                    .HasColumnType("text")
                    .HasColumnName("logradoutro");

                entity.Property(e => e.Nome)
                    .HasColumnType("text")
                    .HasColumnName("nome");

                entity.Property(e => e.Telefone1)
                    .HasColumnType("text")
                    .HasColumnName("telefone1");

                entity.Property(e => e.Telefone2)
                    .HasColumnType("text")
                    .HasColumnName("telefone2");
            });

            modelBuilder.Entity<DadosIniciais2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DadosIniciais2");

                entity.Property(e => e.AnoFormatura)
                    .HasColumnType("text")
                    .HasColumnName("anoFormatura");

                entity.Property(e => e.Bairro)
                    .HasColumnType("text")
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .HasColumnType("text")
                    .HasColumnName("cep");

                entity.Property(e => e.Cidade)
                    .HasColumnType("text")
                    .HasColumnName("cidade");

                entity.Property(e => e.Complemento)
                    .HasColumnType("text")
                    .HasColumnName("complemento");

                entity.Property(e => e.Cpf)
                    .HasColumnType("text")
                    .HasColumnName("cpf");

                entity.Property(e => e.Crm)
                    .HasColumnType("text")
                    .HasColumnName("crm");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("text")
                    .HasColumnName("dataNascimento");

                entity.Property(e => e.Email)
                    .HasColumnType("text")
                    .HasColumnName("email");

                entity.Property(e => e.Estado).HasColumnType("text");

                entity.Property(e => e.Logradoutro)
                    .HasColumnType("text")
                    .HasColumnName("logradoutro");

                entity.Property(e => e.Nome)
                    .HasColumnType("text")
                    .HasColumnName("nome");

                entity.Property(e => e.Telefone1)
                    .HasColumnType("text")
                    .HasColumnName("telefone1");

                entity.Property(e => e.Telefone2)
                    .HasColumnType("text")
                    .HasColumnName("telefone2");
            });

            modelBuilder.Entity<DadosNormalizado>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AnoFormatura).HasColumnName("anoFormatura");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cep");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cidade");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("complemento");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cpf");

                entity.Property(e => e.Crm).HasColumnName("crm");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("datetime")
                    .HasColumnName("dataNascimento");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Especialidade).HasColumnName("especialidade");

                entity.Property(e => e.Logradoutro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logradoutro");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Sexo).HasColumnName("sexo");

                entity.Property(e => e.Telefone1)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefone1");

                entity.Property(e => e.Telefone2)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefone2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
