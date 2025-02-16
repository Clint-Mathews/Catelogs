﻿using Catalogs.Entities;

namespace Catalogs.Repositories
{
    public interface IInMemItemsRepository
    {
        Task<Item?> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(Guid item);
    }
}