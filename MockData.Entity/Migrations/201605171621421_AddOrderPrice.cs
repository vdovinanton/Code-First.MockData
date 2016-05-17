namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Price", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Price");
        }
    }
}
