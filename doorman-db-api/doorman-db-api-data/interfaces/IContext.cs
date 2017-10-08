namespace doorman_db_api.data.interfaces
{
    using entities;
    using implementations.entities;
    using System;
    using System.Data.Entity;

    public interface IContext : IDisposable
    {
        DbSet<CardEntity> Cards { get; }
        int SaveChanges();
        void SetModified(IEntity entity);
    }
}
