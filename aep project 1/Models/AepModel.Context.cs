﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aep_project_1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AepEntities : DbContext
    {
        public AepEntities()
            : base("name=AepEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SCORECARD_FACT> SCORECARD_FACT { get; set; }
        public virtual DbSet<SCORECARD_PHOTO_FACT> SCORECARD_PHOTO_FACT { get; set; }
    }
}
