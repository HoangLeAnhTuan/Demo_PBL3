﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo1.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PBL3_demoEntities : DbContext
    {
        public PBL3_demoEntities()
            : base("name=PBL3_demoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccessRight> AccessRights { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Parcel> Parcels { get; set; }
        public virtual DbSet<Receptionist> Receptionists { get; set; }
        public virtual DbSet<ShippingFee> ShippingFees { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WarehouseManager> WarehouseManagers { get; set; }
        public virtual DbSet<WarehouseStaff> WarehouseStaffs { get; set; }
    }
}