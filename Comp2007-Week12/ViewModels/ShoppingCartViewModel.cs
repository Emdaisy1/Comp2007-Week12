using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Comp2007_Week12.Models;

namespace Comp2007_Week12.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}