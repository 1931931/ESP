using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleAdmin.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ModuleAdmin
{
    public class ModuleAdminFactory : IDesignTimeDbContextFactory<ModuleAdminContext>
    {
        public ModuleAdminContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "appsettings.json"))
            .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ModuleAdminContext>();
            optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(8, 0, 21)));

            return new ModuleAdminContext(optionsBuilder.Options);
        }
    }
}
