namespace doorman_db_api.data.implementations
{
    using interfaces;
    using System;
    using repositories;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IContext _context;
        private CardRepository _cardRepository;

        public UnitOfWork(IContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            _context = context;
        }

        public CardRepository CardRepository
        {
            get
            {
                if (_cardRepository == null)
                    _cardRepository = new CardRepository(_context);
                return _cardRepository;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                }
            }
        }
    }
}
