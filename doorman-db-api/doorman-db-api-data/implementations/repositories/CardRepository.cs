namespace doorman_db_api.data.implementations.repositories
{
    using interfaces.repositories;
    using System;
    using System.Linq;
    using entities;
    using interfaces.entities;
    using interfaces;

    public class CardRepository : ICardRepository
    {
        private readonly IContext _context;

        public CardRepository(IContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            _context = context;
        }

        public IQueryable<CardEntity> Get
        {
            get
            {
                return _context.Cards;
            }
        }

        public void Add(ICardEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _context.Cards.Add(entity as CardEntity);
            _context.SaveChanges();
        }

        public void Delete(ICardEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _context.Cards.Remove(entity as CardEntity);
            _context.SaveChanges();
        }
    }
}
