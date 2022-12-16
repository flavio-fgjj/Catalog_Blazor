using Catalog_Blazor.Shared.Resources;

namespace Catalog_Blazor.Server.Utils
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, Pagination pagination)
        {
            return queryable
                .Skip((pagination.Page - 1) * pagination.TotalPerPage)
                .Take(pagination.TotalPerPage);

        }
    }
}
