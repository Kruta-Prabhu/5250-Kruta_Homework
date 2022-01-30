using System;
using SQLite;

namespace Mine.Models
{
    /// <summary>
    /// Items for characters and monsters to use
    /// </summary>
    public class ItemModel
    {
        //Id for the Item
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        //The display text For the Item
        public string Text { get; set; }

        //The description for the item
        public string Description { get; set; }

        //The value of Item +9 damage
        public int value { get; set; } = 0;

    }
}