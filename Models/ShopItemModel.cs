using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class ShopItemModel
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Name of product")]
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(70)]
        public string Name { get; set; }

        [DisplayName("Your description")]
        [MaxLength(200)]
        public string Description { get; set; }

        [DisplayName("Where I can find")]
        public string Section { get; set; }
        public bool Taken { get; set; }
    }
}
