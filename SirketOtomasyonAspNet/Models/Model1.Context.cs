﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SirketOtomasyonAspNet.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ASPNETSirketEntities : DbContext
    {
        public ASPNETSirketEntities()
            : base("name=ASPNETSirketEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Birimler> Birimlers { get; set; }
        public virtual DbSet<Duyurular> Duyurulars { get; set; }
        public virtual DbSet<Iletisim> Iletisims { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }
        public virtual DbSet<PersonelBasarılari> PersonelBasarılari { get; set; }
        public virtual DbSet<Personeller> Personellers { get; set; }
        public virtual DbSet<Sirket> Sirkets { get; set; }
        public virtual DbSet<SirketHakkinda> SirketHakkindas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Yetkilendirme> Yetkilendirmes { get; set; }
    }
}