using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pumps.Models;

namespace Pumps.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {


        }
        public DbSet<Pump.Models.Pump> Pump { get; set; } = default!;
        public DbSet<Pump.Models.Rope> Rope { get; set; } = default!;
        public DbSet<Pump.Models.HydraulicAccumulator> HydraulicAccumulator { get; set; } = default!;
        public DbSet<Pump.Models.Clamp> Clamp { get; set; } = default!;
        public DbSet<Pump.Models.Pipe> Pipe { get; set; } = default!;
        public DbSet<Pump.Models.Cap> Cap { get; set; } = default!;
        public DbSet<Pump.Models.UnderwaterСable> UnderwaterСable { get; set; } = default!;
        public DbSet<Pump.Models.Automation> Automation { get; set; } = default!;
        public DbSet<Pump.Models.Equipment> Equipment { get; set; } = default!;
    }
}