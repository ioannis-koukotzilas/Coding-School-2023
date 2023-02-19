namespace FuelStation.EF.Repositories {

    public interface IEntityRepo<TEntity> {

        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);

    }

}