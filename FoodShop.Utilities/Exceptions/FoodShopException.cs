using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShop.Utilities.Exceptions
{
    public class FoodShopException : Exception
    {
        public FoodShopException()
        {
        }

        public FoodShopException(string message)
            : base(message)
        {
        }

        public FoodShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
