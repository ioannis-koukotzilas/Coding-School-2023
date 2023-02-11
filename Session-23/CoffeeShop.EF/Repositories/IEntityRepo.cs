using System;

namespace CoffeeShop.EF.Repositories {

    public interface IEntityRepo<TEntity> {

        IList<TEntity> GetAll();

        TEntity? GetById(int id);

        void Add(TEntity entity);

        void Update(int id, TEntity entity);

        void Delete(int id);

    }

}

