using AutoMapper;
using Azure.Core;
using Store.Data.Repositories;
using Store.Data.Repositories.Contract;
using Store.Dto;
using Store.Entities;
using Store.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    public class CartItemService : ICartItemService
    {
        public readonly ICartItemRepository _cartItemRepository;
        public readonly IMapper _mapper;

        public CartItemService(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }

        public async Task<int> AddItem(CartItemDto item)
        {
            var itemToAdd = _mapper.Map<CartItem>(item);
            return await _cartItemRepository.AddItem(itemToAdd);
        }

        public async Task<int> DeleteItem(int id)
        {
            var cartToDelete = _mapper.Map<CartItemDto>(id);
            return await _cartItemRepository.DeleteItem(cartToDelete.Id);
        }

        public async Task<List<CartItemDto>> GetByUser(int userId)
        {
            var cartToFind = await _cartItemRepository.GetByUser(userId);
            return _mapper.Map<List<CartItemDto>>(cartToFind);
        }

        public async Task<int> UpdateItem(CartItemDto item)
        {
            var cartToUpdate = _mapper.Map<CartItem>(item.Id);
            return await _cartItemRepository.UpdateItem(cartToUpdate);
        }
    }
}
