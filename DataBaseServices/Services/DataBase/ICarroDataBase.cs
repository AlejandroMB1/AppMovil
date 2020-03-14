using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseServices.Services.DataBase
{
    public interface ICarroDataBase<T> : IServiceDataBase<T> where T : class, new()
    {
        Task<int> InsertAllItemsAsync(IList<T> items);

        Task<int> DeleteAllItemsAsync();

        Task<int> GetAllItemsAsync();

        Task InsertAllItemsWithChildrenAsync(IList<T> items);
               
    }
}
