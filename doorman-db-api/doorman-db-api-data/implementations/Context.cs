namespace doorman_db_api.data.implementations
{
    using System;
    using System.Data.Entity;
    using entities;
    using interfaces.entities;
    using interfaces;

    public class Context : DbContext, IContext
    {
        public DbSet<CardEntity> Cards { get; set; }

        public Context(string connectionString) : base (connectionString) { }

        public void SetModified(IEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            Entry(entity).State = EntityState.Modified;
        }
    }
}
