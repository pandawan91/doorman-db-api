namespace doorman_db_api.data.implementations.entities
{
    using interfaces.entities;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Card")]
    public class CardEntity : ICardEntity
    {
        [Key, Required]
        public int Id { get; set; }

        [Required]
        public int CardId { get; set; }
    }
}
