using Medical.Core.Comman;
using Medical.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using static Medical.Core.Exeptions.ResourceNotFoundException;

namespace Medical.DataAccess.Repository.Impl
{
    public class BaseRepository<TEntity> :IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DataBaseContext _context;
        protected readonly DbSet<TEntity> _dbset;

        protected BaseRepository(DataBaseContext context)
        {
            _context = context;
            _dbset=context.Set<TEntity>();
        }   
        public async Task<TEntity>AddAsync(TEntity entity)
        {
                var addEntity= (await _dbset.AddAsync(entity)).Entity;
                await _context.SaveChangesAsync();
                return addEntity;
        }
        public async Task<TEntity>UpdateAsync(TEntity entity)
        {
            _dbset.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<TEntity>DeleteAsync(TEntity entity)
        {
           var RemoveEntity=(_dbset.Remove(entity)).Entity;
           await _context.SaveChangesAsync();
           return RemoveEntity;
        }

        public IQueryable<TEntity> GetAll() =>
            _dbset.AsQueryable();

        public async Task<List<TEntity>>GetAllAsync(Expression<Func<TEntity,bool>> predicate)
        {
            return await _dbset.Where(predicate).ToListAsync();
        }

        public async Task<List<TEntity>?> GetAllAsync()
        {
            try
            {
                var result=await _dbset.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<TEntity>GetFirstAsync(Expression<Func<TEntity,bool>> predicate)
        {
            var entity=await _dbset.Where(predicate).FirstOrDefaultAsync();
            if(entity == null)throw new ResourceNotFound(typeof(TEntity));
            return entity;
        }
    }
}
