namespace AccountTransactionAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        TaxIdentificationNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NaturalPersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IdentificationNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TransactionDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionDate = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransactionType = c.String(),
                        NaturalPersonId = c.Int(),
                        CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.NaturalPersons", t => t.NaturalPersonId)
                .Index(t => t.NaturalPersonId)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionDatas", "NaturalPersonId", "dbo.NaturalPersons");
            DropForeignKey("dbo.TransactionDatas", "CompanyId", "dbo.Companies");
            DropIndex("dbo.TransactionDatas", new[] { "CompanyId" });
            DropIndex("dbo.TransactionDatas", new[] { "NaturalPersonId" });
            DropTable("dbo.TransactionDatas");
            DropTable("dbo.NaturalPersons");
            DropTable("dbo.Companies");
        }
    }
}
