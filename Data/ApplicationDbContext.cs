using AccountTransactionAPP.Models;
using System.Data.Entity;
using System.Transactions;
//using System.Data.Entity;

namespace AccountTransactionAPP.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() : base("Server=DESKTOP-ARHUSLN;Database=TransactionsBlueSoft;User Id=Mario;Trusted_Connection=True;") { }
        public DbSet<NaturalPerson?> NaturalPersons { get; set; }
        public DbSet<Company?> Companies { get; set; }
        public DbSet<Models.Transaction?> Transac { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Transaction>();
                        //.HasOne(t => t.NaturalPerson)
                        //.WithMany()  // Si la relación es uno a muchos
                        //.HasForeignKey(t => t.NaturalPersonId);

            //modelBuilder.Entity<Transaction>()
                        //.HasOne(t => t.Company)
                        //.WithMany()  // Si la relación es uno a muchos
                        //.HasForeignKey(t => t.CompanyId);
            // Optional: Fluent API to enforce some rules.
        }
    }
}
