namespace UniversityofLouisvilleVaccine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedExpirationDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vaccines", "expDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vaccines", "expDate");
        }
    }
}
