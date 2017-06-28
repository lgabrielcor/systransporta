using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sysTransporta.Models
{
    public class Tr2Context : DbContext
    {
        public Tr2Context() : base("name=DefaultConnection")
        {
        }

        // public System.Data.Entity.DbSet<PosSaaray.Models.Proveedor> Proveedors { get; set; }
        public System.Data.Entity.DbSet<sysTransporta.Models.Company> Companies { get; set; }
        public System.Data.Entity.DbSet<sysTransporta.Models.Vehicle> Vehicles { get; set; }
        public System.Data.Entity.DbSet<sysTransporta.Models.Driver> Drivers { get; set; }

        public System.Data.Entity.DbSet<sysTransporta.Models.Plan> Plans { get; set; }
        public System.Data.Entity.DbSet<sysTransporta.Models.DocumentType> DocumentTypes { get; set; }
        public System.Data.Entity.DbSet<sysTransporta.Models.LicenseType> LicenseTypes { get; set; }
        public System.Data.Entity.DbSet<sysTransporta.Models.Country> Countries { get; set; }
    }
}