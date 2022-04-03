using PhoneBookApp.Web.Data.Context;
using PhoneBookApp.Web.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Web.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class , new()
    {
        private readonly PhoneContext _context;

        public GenericRepository(PhoneContext context)
        {
            _context = context;
        }

        public void Create (T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Remove (T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }



    }

}
