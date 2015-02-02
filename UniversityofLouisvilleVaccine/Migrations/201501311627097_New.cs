namespace UniversityofLouisvilleVaccine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vaccines", "vaccineName", c => c.String(nullable: false));
            AlterColumn("dbo.Vaccines", "CPT", c => c.String(nullable: false));
            AlterColumn("dbo.Vaccines", "ICD9Code", c => c.String(nullable: false));
            AlterColumn("dbo.Vaccines", "NDC", c => c.String(nullable: false));
            AlterColumn("dbo.Vaccines", "lotNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vaccines", "lotNumber", c => c.String());
            AlterColumn("dbo.Vaccines", "NDC", c => c.String());
            AlterColumn("dbo.Vaccines", "ICD9Code", c => c.String());
            AlterColumn("dbo.Vaccines", "CPT", c => c.String());
            AlterColumn("dbo.Vaccines", "vaccineName", c => c.String());
        }
    }
}
