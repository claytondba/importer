using System;
using Microsoft.EntityFrameworkCore;

namespace Importer
{
	public class DataContext: DbContext
	{
		public DbSet<PecaModel> PecasImportar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var conn = "server=data.devplus.com.br;user id=root;Pwd=Devplus@2019; persistsecurityinfo=True;database=nova;convert zero datetime=True";
            var conn = "server=acesso.mic.ind.br; Port=33306;user id=root;Pwd=beleza; persistsecurityinfo=True;database=nova;convert zero datetime=True";
            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            //base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PecasConfiguration());
        }
    }
	
}

