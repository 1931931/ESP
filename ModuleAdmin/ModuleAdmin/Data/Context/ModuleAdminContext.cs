using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ModuleAdmin.Model;

namespace ModuleAdmin.Data.Context
{
    public class ModuleAdminContext : DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Billet> Billet { get; set; }
        public DbSet<Employe> Employe { get; set; }
        public DbSet<Stationnement> Stationnement { get; set; }
        public DbSet<Tarif> Tarif { get; set; }
        public DbSet<TarifDynamique> TarifDynamique { get; set; }
        public ModuleAdminContext(DbContextOptions<ModuleAdminContext> options) : base(options) { }
    }

}
