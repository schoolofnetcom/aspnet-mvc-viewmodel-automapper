namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelToViewModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Cpf", c => c.String());
            AlterColumn("dbo.Pessoas", "Nome", c => c.String());
            AlterColumn("dbo.Pessoas", "Sobrenome", c => c.String());
            AlterColumn("dbo.Pessoas", "Email", c => c.String());
            AlterColumn("dbo.Pessoas", "NomeMae", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "NomeMae", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Pessoas", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Pessoas", "Sobrenome", c => c.String(maxLength: 20));
            AlterColumn("dbo.Pessoas", "Nome", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Pessoas", "Cpf", c => c.String(nullable: false, maxLength: 11));
        }
    }
}
