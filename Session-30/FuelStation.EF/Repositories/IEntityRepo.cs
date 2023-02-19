namespace FuelStation.EF.Repositories {

    public interface IEntityRepo<TEntity> {

        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(int id);
        Task AddAsync(TEntity entity);
        void Update(int id, TEntity entity);
        Task DeleteAsync(int id);

    }

}