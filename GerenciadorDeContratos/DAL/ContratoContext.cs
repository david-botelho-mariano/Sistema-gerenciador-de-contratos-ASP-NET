using GerenciadorDeContratos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace GerenciadorDeContratos.DAL
{
    public class ContratoContext : DbContext
    {
        public ContratoContext() : base("ContratoContext")
        {

        }

        public DbSet<Contato> Contatos { get; set;}
        public DbSet<Contratado> Contratados { get; set; }

        public DbSet<Contratante> Contratantes { get; set; }

        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Gestor> Gestores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}