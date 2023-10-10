using System;
using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            _cartItems.AddRange(cartItems);
        }

        public void Remove(List<CartItem> cartItemsToRemove)
        {
            _cartItems.RemoveRange(0, cartItemsToRemove.Count);
        }

        public List<CartItem> CartItems
        {
            get
            {
                return _cartItems;
            }
        }

        public float Price
        {
            get
            {
                return _cartItems.Count;        
            }
        }
        #endregion public methods
    }
}
