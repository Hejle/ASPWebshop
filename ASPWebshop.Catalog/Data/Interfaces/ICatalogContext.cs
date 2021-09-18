using ASPWebshop.Catalog.Entities;
using MongoDB.Driver;

namespace ASPWebshop.Catalog.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
