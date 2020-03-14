using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataBaseServices.Models;

namespace DataBaseServices.Services.DataBase
{
    public interface IUsuarioDataBase<T> : IServiceDataBase<T> where T: class, new()
    {
        Task InsertWithChildrenAsync(UsuarioModel item);

        Task<List<T>> GetAllItemsWithChildrenAsync();

        Task<List<T>> GetUserByNumDocumentAsync(string documento);
    }
}
