﻿using Microsoft.AspNetCore.Identity;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        public decimal TotalPrice { get
            {
                decimal totalPrice =0;
                foreach (var item in Items)
                {
                    totalPrice += item.Quantity * item.Price;
                }
                return totalPrice;
            }}

        public ShoppingCart()
        {
        }
        public ShoppingCart(string userName)
        {
            this.UserName = userName;
        }
    }
}
