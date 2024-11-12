using IFSPStore.Domain.Base;
using IFSPStore.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Repository
{
    //esse é de fato o nosso repositório (aqui é importante)
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly MySQLContext _MySqlContext; //é através do context que conectamos ao banco de dados
        public void AtachObject(object obj)
        {
            _MySqlContext.Attach(obj);
        }

        public BaseRepository(MySQLContext MySqlContext)
        {
            _MySqlContext = MySqlContext;
        }

        public void ClearChangeTracker()
        {
            _MySqlContext.ChangeTracker.Clear();
        }

        public void Delete(object id) //método do crud
        {
            _MySqlContext.Set<TEntity>().Remove(Select(id));
            _MySqlContext.SaveChanges();
        }


        public void Insert(TEntity entity) //método do crud
        {
            _MySqlContext.Set<TEntity>().Add(entity);
            _MySqlContext.SaveChanges();
        }

        public IList<TEntity> Select(IList<string>? includes = null) //as includes é referente ao relacionamento entre as tabelas, traz também os dados das chaves estrangeiras
        {
            var dbContext = _MySqlContext.Set<TEntity>().AsQueryable();
            if(includes != null)
            {
                foreach(var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList();
        }

        public TEntity Select(object id, IList<string>? includes = null)
        {
            var dbContext = _MySqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList().Find(x => x.Id == (int)id);
        }

        public void Update(TEntity entity)
        {
            _MySqlContext.Entry(entity).State = EntityState.Modified;
            _MySqlContext.SaveChanges();
        }
    }
}
