using Microsoft.EntityFrameworkCore;

namespace Catalog_Blazor.Server.Utils
{
    public static class HttpContextExtensions
    {
        public async static Task InsertParameterAtPageResponse<T>(this HttpContext context, IQueryable<T> queryable, int totalRecordsToShow)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            double totalRecords = await queryable.CountAsync();
            double totalPages = Math.Ceiling(totalRecords / totalRecordsToShow);

            context.Response.Headers.Add("totalRecords", totalRecords.ToString());
            context.Response.Headers.Add("totalPages", totalPages.ToString());
        }
    }
}
