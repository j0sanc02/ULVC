namespace UniversityofLouisvilleVaccine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vaccines",
                c => new
                    {
                        vaccineID = c.String(nullable: false, maxLength: 128),
                        vaccineName = c.String(),
                        dateReceived = c.DateTime(nullable: false),
                        CPT = c.String(),
                        ICD9Code = c.String(),
                        NDC = c.String(),
                        leadTime = c.Int(nullable: false),
                        lotNumber = c.String(),
                        numofDoses = c.Int(nullable: false),
                        salesPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.vaccineID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vaccines");
        }
    }
}
