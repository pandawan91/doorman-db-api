namespace doorman_db_api.service.implementations
{
    using data.implementations;
    using data.implementations.entities;
    using data.interfaces;
    using interfaces;
    using System;
    using System.Linq;

    public class CardService : ICardService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CardService(IContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            _unitOfWork = new UnitOfWork(context);
        }

        public void AddCardIdIfNotExists(int cardId)
        {
            if (cardId < 0)
                throw new ArgumentOutOfRangeException(nameof(cardId));
            if(!_unitOfWork.CardRepository.Get.Any(x => x.CardId == cardId))
            {
                _unitOfWork.CardRepository.Add(new CardEntity()
                {
                    CardId = cardId
                });
            }
        }

        public bool IsCardIdInDataBase(int cardId)
        {
            if (cardId < 0)
                throw new ArgumentOutOfRangeException(nameof(cardId));
            return _unitOfWork.CardRepository.Get.Any(x => x.CardId == cardId);
        }
    }
}
