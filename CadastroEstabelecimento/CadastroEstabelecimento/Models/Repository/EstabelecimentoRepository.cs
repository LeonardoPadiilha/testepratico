using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadastroEstabelecimento.Models.Repository
{
    public class EstabelecimentoRepository : IRepository<Estabelecimento>
    {
        static Contexto ctx = new Contexto();
        private Contexto contexto;

        public EstabelecimentoRepository(Contexto ctx)
        {
            this.contexto = ctx;
        }

        public void Add(Estabelecimento estabelecimento)
        {
            contexto.Estabelecimentos.Add(estabelecimento);
            contexto.SaveChanges();
        }

        public void Delete(Estabelecimento estabelecimento)
        { 
                contexto.Estabelecimentos.Remove(estabelecimento);
                contexto.SaveChanges();
        }

        

        public List<Estabelecimento> GetAll()
        {
            return contexto.Estabelecimentos.ToList();
        }

        public Estabelecimento GetById(int id)
        {
            return contexto.Estabelecimentos.Find(id);
        }

        public void Update(Estabelecimento entity)
        {
            try
            {
                Estabelecimento estabelecimento = contexto.Set<Estabelecimento>().Local.FirstOrDefault(model => model.IdEstabelecimento == entity.IdEstabelecimento);
                if (estabelecimento != null)
                {
                    contexto.Entry(estabelecimento).State = EntityState.Detached;
                }

                contexto.Entry(entity).State = EntityState.Modified;
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}