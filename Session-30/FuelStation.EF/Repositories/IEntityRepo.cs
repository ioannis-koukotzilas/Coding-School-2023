namespace FuelStation.EF.Repositories {

    public interface IEntityRepo<TEntity> {

        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(int id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(int id, TEntity entity);
        Task DeleteAsync(int id);

    }

}