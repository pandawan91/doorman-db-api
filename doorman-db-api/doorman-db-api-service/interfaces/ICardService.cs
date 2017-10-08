namespace doorman_db_api.service.interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICardService
    {
        void AddCardIdIfNotExists(int cardId);
        bool IsCardIdInDataBase(int cardId);
    }
}
