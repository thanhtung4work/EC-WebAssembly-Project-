using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(Game game);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);
    }
}
