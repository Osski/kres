﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kres.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kresEntities : DbContext
    {
        public kresEntities()
            : base("name=kresEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ogrenci> ogrenci { get; set; }
        public virtual DbSet<ogrencisinif> ogrencisinif { get; set; }
        public virtual DbSet<ogrenciveli> ogrenciveli { get; set; }
        public virtual DbSet<ogretmen> ogretmen { get; set; }
        public virtual DbSet<siniflar> siniflar { get; set; }
        public virtual DbSet<sinifogretmen> sinifogretmen { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<veli> veli { get; set; }
        public virtual DbSet<ders> ders { get; set; }
        public virtual DbSet<DersProgrami> DersProgrami { get; set; }
    }
}
