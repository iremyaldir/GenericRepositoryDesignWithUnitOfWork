namespace GenericRepositoryDesignWithUnitOfWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Horses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedTime = c.DateTime(),
                        UpdatedTime = c.DateTime(),
                        DeletedTime = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jockeys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        HorseId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        UpdatedTime = c.DateTime(),
                        DeletedTime = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Horses", t => t.HorseId, cascadeDelete: true)
                .Index(t => t.HorseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jockeys", "HorseId", "dbo.Horses");
            DropIndex("dbo.Jockeys", new[] { "HorseId" });
            DropTable("dbo.Jockeys");
            DropTable("dbo.Horses");
        }
    }
}
