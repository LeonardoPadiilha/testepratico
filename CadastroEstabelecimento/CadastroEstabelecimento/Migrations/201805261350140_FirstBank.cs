namespace CadastroEstabelecimento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstBank : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estabelecimentoes",
                c => new
                    {
                        IdEstabelecimento = c.Int(nullable: false, identity: true),
                        RazaoSocial = c.String(nullable: false, maxLength: 40),
                        NomeFantasia = c.String(nullable: false, maxLength: 40),
                        Cnpj = c.String(nullable: false, maxLength: 20),
                        Email = c.String(maxLength: 30),
                        Endereco = c.String(maxLength: 30),
                        Cidade = c.String(maxLength: 30),
                        Estado = c.String(maxLength: 30),
                        Telefone = c.Int(nullable: false),
                        DataInclusao = c.String(),
                        Categoria = c.String(),
                        Status = c.String(),
                        Agencia = c.String(),
                        Conta = c.String(),
                    })
                .PrimaryKey(t => t.IdEstabelecimento);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Estabelecimentoes");
        }
    }
}
