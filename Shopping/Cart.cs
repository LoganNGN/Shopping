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
            _cartItems.Clear();
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
                float totalprice = 0f;
                foreach (var cartItem in _cartItems)
                {
                    totalprice += cartItem.Article.Price * cartItem.Quantity;
                }
                return totalprice;
            }
        }
        #endregion public methods
    }
}
