﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NativaGaragem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntidadesNativaGaragem : DbContext
    {
        public EntidadesNativaGaragem()
            : base("name=EntidadesNativaGaragem")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Garagem> Garagem { get; set; }
        public DbSet<Limpeza> Limpeza { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Realizacao> Realizacao { get; set; }
        public DbSet<Solicitacao> Solicitacao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Vaga> Vaga { get; set; }
    }
}
