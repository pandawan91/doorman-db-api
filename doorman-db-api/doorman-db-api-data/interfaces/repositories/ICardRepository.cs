namespace doorman_db_api.data.interfaces.repositories
{
    using entities;
    using implementations.entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICardRepository
    {
        IQueryable<CardEntity> Get { get; }
        void Add(ICardEntity entity);
        void Delete(ICardEntity entity);
    }
}
