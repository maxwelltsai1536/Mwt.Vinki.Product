using Microsoft.EntityFrameworkCore;
using Mwt.Vinki.Product.Entity;
using Mwt.Vinki.Product.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Mwt.Vinki.Product.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See ProductMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class ProductDbContext : AbpDbContext<ProductDbContext>
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Entity.Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Media> Medias { set; get; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside ProductDbContextModelCreatingExtensions.ConfigureProduct
         */

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the ProductEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureProduct method */

            builder.ConfigureProduct();
        }
    }
}
