namespace doorman_db_api.Controllers
{
    using data.implementations;
    using data.interfaces;
    using service.implementations;
    using service.interfaces;
    using System;
    using System.Web.Http;

    public class CardController : ApiController
    {
        private readonly ICardService _cardService;

        public CardController(IContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            _cardService = new CardService(context);
        }

        public CardController() : this(new Context("name=doorman-db")) { }

        // POST /api/card/add
        [HttpPost]
        public void Add([FromBody] int cardId)
        {
            if (cardId < 0)
                throw new ArgumentOutOfRangeException(nameof(cardId));
            _cardService.AddCardIdIfNotExists(cardId);
        }

        // Get /api/card/validate/{cardId}
        [HttpGet]
        public bool ValidateCard([FromUri] int cardId)
        {
            if (cardId < 0)
                throw new ArgumentOutOfRangeException(nameof(cardId));
            return _cardService.IsCardIdInDataBase(cardId);
        }
    }
}