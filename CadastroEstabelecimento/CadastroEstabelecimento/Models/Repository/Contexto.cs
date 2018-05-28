namespace CadastroEstabelecimento.Models.Repository
{
    using System.Data.Entity;

    public class Contexto : DbContext
    {

        public virtual DbSet<Estabelecimento> Estabelecimentos { get; set; }
      
        public Contexto()
            : base("name=Contexto")
        {
        }

        
    }

    
}