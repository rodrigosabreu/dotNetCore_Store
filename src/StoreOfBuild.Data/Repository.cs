using StoreOfBuild.Domain;
using System.Linq;

namespace StoreOfBuild.Data
{    
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity// Isso é igual qualquer entidade
    
    {
        private readonly ApplicationDbContext _context;

        public Repository (ApplicationDbContext context)
        {
            _context = context;
        }


        public TEntity GetById(int id)
        {
           //return _context.Set<TEntity>().SingleOrDefault(e => e.Id == id);


            var query = _context.Set<TEntity>().Where(e => e.Id == id);
            if(query.Any())
                return query.First();
            return null;

           
        }
        public void Save(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            //_context.SaveChanges();
            //^se executar o SaveChanges vai finalizar o AppDbContext e não vai conseguir fazer mais instrucoes
            //o ideial é executar no final da requisicao
        }
    }
}