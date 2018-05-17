namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Autor", "Email", c => c.String());
            AddColumn("dbo.Autor", "DtNascimento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Book", "Ano", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Book", "Ano");
            DropColumn("dbo.Autor", "DtNascimento");
            DropColumn("dbo.Autor", "Email");
        }
    }
}
