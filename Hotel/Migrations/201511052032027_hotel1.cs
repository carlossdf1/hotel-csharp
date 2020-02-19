namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hotel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Capacidad = c.Short(nullable: false),
                        Precio = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habitacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoriaHabitacion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaHabitacion_Id)
                .Index(t => t.CategoriaHabitacion_Id);
            
            CreateTable(
                "dbo.Huespeds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        HabitacionHuesped_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Habitacions", t => t.HabitacionHuesped_Id)
                .Index(t => t.HabitacionHuesped_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Huespeds", "HabitacionHuesped_Id", "dbo.Habitacions");
            DropForeignKey("dbo.Habitacions", "CategoriaHabitacion_Id", "dbo.Categorias");
            DropIndex("dbo.Huespeds", new[] { "HabitacionHuesped_Id" });
            DropIndex("dbo.Habitacions", new[] { "CategoriaHabitacion_Id" });
            DropTable("dbo.Huespeds");
            DropTable("dbo.Habitacions");
            DropTable("dbo.Categorias");
        }
    }
}
