namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuevosdatos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Huespeds", "Apellido", c => c.String());
            AddColumn("dbo.Huespeds", "Rut", c => c.String());
            AddColumn("dbo.Huespeds", "Correo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Huespeds", "Correo");
            DropColumn("dbo.Huespeds", "Rut");
            DropColumn("dbo.Huespeds", "Apellido");
        }
    }
}
