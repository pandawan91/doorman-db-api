namespace doorman_db_api.service.interfaces
{
    public interface ICardService
    {
        void AddCardIdIfNotExists(int cardId);
        bool IsCardIdInDataBase(int cardId);
    }
}
