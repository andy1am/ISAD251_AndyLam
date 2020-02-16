using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ISAD251_AndyLam.Models;

namespace ISAD251_AndyLam.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}