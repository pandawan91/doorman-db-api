namespace doorman_db_api.service.interfaces
{
    public interface ICardService
    {
        void AddCardIdIfNotExists(long cardId);
        bool IsCardIdInDataBase(long cardId);
    }
}
