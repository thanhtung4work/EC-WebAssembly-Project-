using Blazored.LocalStorage;
using Blazored.Toast.Services;
using Suchimu.Client.Services.GameService;
using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IGameService _gameService;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage,
            IToastService toastService,
            IGameService gameService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _gameService = gameService;
        }

        public async Task AddToCart(Game game)
        {
            var cart = await _localStorage.GetItemAsync<List<Game>>("cart");
            if(cart == null)
            {
                cart = new List<Game>();
            }
            cart.Add(game);
            await _localStorage.SetItemAsync("cart", cart);
            var _game = await _gameService.GetGame(game.Id);
            _toastService.ShowSuccess(_game.Title, "Đã thêm vào giỏ!");
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var result = new List<CartItem>();
            var cart = await _localStorage.GetItemAsync<List<Game>>("cart");
            if(cart == null)
            {
                return result;
            }
            foreach(var item in cart)
            {
                var game = await _gameService.GetGame(item.Id);
                var cartItem = new CartItem
                {
                    GameId = game.Id,
                    GameTitle = game.Title,
                    Image = game.ImageUrl,
                    Price = game.Price
                };
                result.Add(cartItem);
            }
            return result;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<Game>>("cart");
            if(cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.Id == item.GameId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }
    }
}
