using System.Threading.Tasks;

namespace ECommerce.Api.Search.Interfaces
{
    public interface ISearchService
    {
        Task<(bool IsSucess, dynamic SearchResults)> SearchAsync(int customerId);
    }
}
