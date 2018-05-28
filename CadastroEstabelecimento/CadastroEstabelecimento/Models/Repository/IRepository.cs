using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEstabelecimento.Models.Repository
{
    interface IRepository<T>
    {
        T GetById(int id);

        List<T> GetAll();

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}