using SongsLibrary_Persistance.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsLibrary_Persistance
{
    internal class SongsLibraryContext : DbContext
    {
#if !DEBUG
        static MOPCContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MOPCContext, Migrations.Configuration>());
        }
#endif
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artist { get; set; }

        public SongsLibraryContext()
            : base("name=SongsLibraryConnectionString")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        /// <summary>
        /// This will override OnModelCreating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));
            base.OnModelCreating(modelBuilder);
        }
    }
}
