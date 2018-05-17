namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autor",
                c => new
                    {
                        AutorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sobrenome = c.String(),
                    })
                .PrimaryKey(t => t.AutorId);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Isbn = c.String(),
                        Titulo = c.String(),
                    })
                .PrimaryKey(t => t.BookId);
            
            CreateTable(
                "dbo.BookAutor",
                c => new
                    {
                        Book_BookId = c.Int(nullable: false),
                        Autor_AutorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_BookId, t.Autor_AutorId })
                .ForeignKey("dbo.Book", t => t.Book_BookId, cascadeDelete: true)
                .ForeignKey("dbo.Autor", t => t.Autor_AutorId, cascadeDelete: true)
                .Index(t => t.Book_BookId)
                .Index(t => t.Autor_AutorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookAutor", "Autor_AutorId", "dbo.Autor");
            DropForeignKey("dbo.BookAutor", "Book_BookId", "dbo.Book");
            DropIndex("dbo.BookAutor", new[] { "Autor_AutorId" });
            DropIndex("dbo.BookAutor", new[] { "Book_BookId" });
            DropTable("dbo.BookAutor");
            DropTable("dbo.Book");
            DropTable("dbo.Autor");
        }
    }
}
