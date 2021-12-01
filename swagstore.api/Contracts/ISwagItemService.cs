using swagstore.api.Models;

namespace swagstore.api.Contracts;

public interface ISwagItemService
{
    IEnumerable<SwagItem> GetAll();
}