namespace FirstWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Observation : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Product", name: "varchar", newName: "Name");
            AddColumn("dbo.Product", "Observation", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Product", "Name", c => c.String(maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "Name", c => c.String());
            DropColumn("dbo.Product", "Observation");
            RenameColumn(table: "dbo.Product", name: "Name", newName: "varchar");
        }
    }
}
