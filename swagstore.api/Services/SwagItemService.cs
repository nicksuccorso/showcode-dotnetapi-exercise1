using swagstore.api.Contracts;
using swagstore.api.Models;

namespace swagstore.api.Services;

public class SwagItemService : ISwagItemService
{
    private readonly List<SwagItem> _swagItems;

    public SwagItemService()
    {
        _swagItems = GenerateSwagItems();
    }

    public IEnumerable<SwagItem> GetAll()
    {
        return _swagItems;
    }

    private List<SwagItem> GenerateSwagItems()
    {
        return Enumerable.Range(1, 5).Select(index => new SwagItem
        {
            Id = 123123,
            ItemName = "test",
            IsPersonalisable = true
            })
        .ToList<SwagItem>();
    }

}

