﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buraktestediyor.Models.ef
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ogrenciEntities : DbContext
    {
        public ogrenciEntities()
            : base("name=ogrenciEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bolum> bolum { get; set; }
        public virtual DbSet<dersler> dersler { get; set; }
        public virtual DbSet<hocalar> hocalar { get; set; }
        public virtual DbSet<memleket> memleket { get; set; }
        public virtual DbSet<ogrenci> ogrenci { get; set; }
        public virtual DbSet<unvanlar> unvanlar { get; set; }
    }
}