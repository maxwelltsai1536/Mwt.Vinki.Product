using Microsoft.EntityFrameworkCore;
using Mwt.Vinki.Product.Entity;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Mwt.Vinki.Product.EntityFrameworkCore
{
    /* This DbContext is only used for database migrations.
     * It is not used on runtime. See ProductDbContext for the runtime DbContext.
     * It is a unified model that includes configuration for
     * all used modules and your application.
     */
    public class ProductMigrationsDbContext : AbpDbContext<ProductMigrationsDbContext>
    {
        public DbSet<Entity.Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Media> Medias { set; get; }

        public ProductMigrationsDbContext(DbContextOptions<ProductMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside the ConfigureProduct method */

            builder.ConfigureProduct();
        }
    }
}