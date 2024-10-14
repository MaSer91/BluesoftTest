namespace AccountTransactionAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TransactionDatas", newName: "Transactions");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Transactions", newName: "TransactionDatas");
        }
    }
}
