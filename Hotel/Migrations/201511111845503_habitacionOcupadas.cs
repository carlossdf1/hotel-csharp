namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class habitacionOcupadas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Habitacions", "Ocupado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Habitacions", "Ocupado");
        }
    }
}
