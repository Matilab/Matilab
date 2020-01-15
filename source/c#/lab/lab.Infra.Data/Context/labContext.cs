﻿using lab.Domain.Entities.Registro;
using lab.Domain.Entities.Cadastro.Auxiliar;
using lab.Infra.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace lab.Infra.Data.Context
{
    public class labContext : DbContext
    {
        DbSet<PessoaFisica> PessoasFisica { get; set; }
        DbSet<PessoaJuridica> PessoasJuridica { get; set; }
        DbSet<Municipio> Municipios { get; set; }
        DbSet<Pais> Paises { get; set; }

        public labContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaFisicaConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaJuridicaConfiguration());
            modelBuilder.ApplyConfiguration(new MunicipioConfiguration());
            modelBuilder.ApplyConfiguration(new PaisConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }

        /*
         * Esta é uma maneira convencional. De outra forma é criar para cada configuração uma classe
         * e instacia-la aqui no construtor
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaFisica>(entt => {
                entt.HasKey(u => u.Id);
                entt.Property(u => u.Nome)
                        .IsRequired()
                        .HasMaxLength(150);
            });
            base.OnModelCreating(modelBuilder);
        }
        */
    }
}