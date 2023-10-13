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

        public void Remove(List<CartItem> cartItemsToRemove = null)
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
                float currentCartPrice = 0f;
                foreach (CartItem cartItem in _cartItems)
                {
                    currentCartPrice += cartItem.Article.Price * cartItem.Quantity;
                }
                return currentCartPrice;
            }
        }

        public int Cheapest()
        {
            throw new NotImplementedException();
        }
        #endregion public methods
        public class CartException : Exception { }
    }
}
