using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseServices.Services.DataBase
{
    public interface IServiceDataBase<T> where T: class, new()
    {
        Task<List<T>> GetItemsAsync();
        Task<T> GetItemAsync(int id);
        Task<int> InsertItemAsync(T item);
        Task<int> UpdateItemAsync(T item);
        Task<int> DeleteItemAsync(T item);
    }
}
