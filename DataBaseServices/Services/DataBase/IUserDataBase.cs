using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseServices.Services.DataBase
{
    public interface IUserDataBase<T> : IServiceDataBase<T> where T: class, new()
    {
        Task<int> InsertAllItemsAsync(IList<T> items);
        Task<int> DeleteAllItemsAsync();
        Task<int> GetAllItemsAsync();
        Task<List<T>> GetAllItemsWithChildrensAsync();
        Task InsertAllItemsWithChildrensAsync(IList<T> items);

        //Task<int> InsertWithChildrensAsync(UsuarioModel item);
    }
}
