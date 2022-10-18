﻿using Shopping.Aggregator.Models;

namespace Shopping.Aggregator.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<CatalogModel>> GetCatalog();
        Task<IEnumerable<CatalogModel>> GetCatalogByCaregory(string category);
        Task<CatalogModel> GetCatalog(string id);
    }
}
