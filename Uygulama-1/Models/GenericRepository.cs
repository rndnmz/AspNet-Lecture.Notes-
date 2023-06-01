using Microsoft.EntityFrameworkCore;

namespace Uygulama_1.Models
{
    public class GenericRepository<T> where T : class
    {
        //Crud işlemleri ile ilgili metotları yazacağız
        private DbSet<T> _object;
        UygulamaContext context =new UygulamaContext();
        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Create(T entity)
        {
          _object.Add(entity);
            context.SaveChanges();
        }
        public void Delete(int id) 
        { 
            T result = _object.Find(id);
            _object.Remove(result);
            context.SaveChanges();
        }

        public void Update(T entity) 
        { 
        }

        public List<T> GetAll() 
        {
            return _object.ToList();
        }
        public T GetById(int id)
        {
            T result = _object.Find(id);
            return result;
        }
    }
}
