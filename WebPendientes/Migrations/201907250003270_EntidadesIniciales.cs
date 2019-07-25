namespace WebPendientes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntidadesIniciales : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CAreas",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        NombreArea = c.String(),
                        ApellidoPaternoResponsable = c.String(nullable: false),
                        ApellidoMaternoResponsable = c.String(nullable: false),
                        NombreResponsable = c.String(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CPendientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        carea_ID = c.Byte(),
                        cproceso_Id = c.Int(),
                        cunidad_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CAreas", t => t.carea_ID)
                .ForeignKey("dbo.CProcesoes", t => t.cproceso_Id)
                .ForeignKey("dbo.CUnidads", t => t.cunidad_Id)
                .Index(t => t.carea_ID)
                .Index(t => t.cproceso_Id)
                .Index(t => t.cunidad_Id);
            
            CreateTable(
                "dbo.CProcesoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CUnidads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Siglas = c.String(nullable: false, maxLength: 3),
                        Nombre = c.String(nullable: false),
                        Telefono = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CPendientes", "cunidad_Id", "dbo.CUnidads");
            DropForeignKey("dbo.CPendientes", "cproceso_Id", "dbo.CProcesoes");
            DropForeignKey("dbo.CPendientes", "carea_ID", "dbo.CAreas");
            DropIndex("dbo.CPendientes", new[] { "cunidad_Id" });
            DropIndex("dbo.CPendientes", new[] { "cproceso_Id" });
            DropIndex("dbo.CPendientes", new[] { "carea_ID" });
            DropTable("dbo.CUnidads");
            DropTable("dbo.CProcesoes");
            DropTable("dbo.CPendientes");
            DropTable("dbo.CAreas");
        }
    }
}
