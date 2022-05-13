using ENG_learning_website.Models;
using Microsoft.EntityFrameworkCore;
namespace ENG_learning_website.Data
{
    public class DBContext :DbContext
    {

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach(var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }


            modelBuilder.Entity<ClientLang>().HasKey(am => new
            {
                am.ClientId,
                am.LangId
            });

            modelBuilder.Entity<ClientLang>().HasOne(m => m.Language).WithMany(am => am.ClientLangs).HasForeignKey(m => m.LangId);
            //modelBuilder.Entity<Course>().Property(x => x.Difficulty).IsRequired();  //maxcharacterLenght do dlugosci 
            modelBuilder.Entity<ClientLang>().HasOne(m => m.Client).WithMany(am => am.Clientlangs).HasForeignKey(m => m.ClientId);
          


          
            base.OnModelCreating(modelBuilder);

        }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; } 
        public DbSet<ClientLang> ClientLang { get; set; } 
        public DbSet<Dictionary> Dictionary { get; set; } 
        public DbSet<Language> Languages { get; set; } 
        public DbSet<Assignment> Assignment { get; set; } 
        public DbSet<Answers> Answers { get; set; } 
        public DbSet<Client> Clients { get; set; } 

     

      

   
    }
}
