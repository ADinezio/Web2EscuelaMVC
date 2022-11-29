namespace Web2EscuelaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aula",
                c => new
                    {
                        EscuelaId = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.EscuelaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aula");
        }
    }
}
