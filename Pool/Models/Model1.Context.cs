﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pool.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PoolEntities : DbContext
    {
        public PoolEntities()
            : base("name=PoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Abonement> Abonements { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<NumberVisit> NumberVisits { get; set; }
        public virtual DbSet<Pool> Pools { get; set; }
        public virtual DbSet<SoldTiket> SoldTikets { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Trener> Treners { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
