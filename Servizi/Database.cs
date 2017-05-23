using Microsoft.EntityFrameworkCore;
using UnicamAppelli.Modello;

namespace UnicamAppelli.Servizi{
    public class Database : DbContext  {
      protected override void OnConfiguring(DbContextOptionsBuilder db){
                db.UseSqlite(@"Data Source=..\..\..\mydb.db;");
      }  

      protected override void OnModelCreating(ModelBuilder mb){
                mb.Entity<Corso>().ToTable("Corsi").HasKey(id => id.IdCorso);
                mb.Entity<Appello>().ToTable("Appelli").HasKey(id => id.IdAppello);
                mb.Entity<Appello>()
                .HasOne(appello => appello.Corso)
                .WithMany(corso => corso.Appelli);

      }

      public DbSet<Corso> Corsi {
            get;
            private set;
      }

      public DbSet<Appello> Appelli {
            get;
            private set;
      }
    }
}