namespace doorman_db_api.data.interfaces
{
    using implementations.repositories;

    public interface IUnitOfWork
    {
        CardRepository CardRepository { get; }
    }
}
