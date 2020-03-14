using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataBaseServices.Models;
using SQLiteNetExtensionsAsync.Extensions;

namespace DataBaseServices.Services.DataBase
{
    public class UsuarioDataBase<T> : IUsuarioDataBase<T> where T: UsuarioModel, new()
    {
        //constructor

        public UsuarioDataBase()
        {
            App.Database.connection.CreateTableAsync<T>().Wait();
            App.Database.connection.CreateTableAsync<CarroModel>().Wait();
        }
        //Metodos
        #region Consultas
        public Task<List<T>> GetItemsAsync()
        {
            return App.Database.connection.Table<T>().ToListAsync();
        }
        public Task<T> GetItemAsync(int id)
        {
            return App.Database.connection.FindAsync<T>(id);
        }
        public Task<int> InsertItemAsync(T item)
        {
            return App.Database.connection.InsertAsync(item);
        }
        public Task<int> UpdateItemAsync(T item)
        {
            return App.Database.connection.UpdateAsync(item);
        }
        public Task<int> DeleteItemAsync(T item)
        {
            return App.Database.connection.DeleteAsync(item);
        }
        public Task<List<T>> GetUserByNumDocumentAsync(string documento)
        {
            return App.Database.connection.Table<T>().Where(i => i.NumDocumento == documento).ToListAsync();
        }
        public async Task InsertWithChildrenAsync(UsuarioModel item)
        {
            await App.Database.connection.InsertWithChildrenAsync(item);
        }
        public Task<List<T>> GetAllItemsWithChildrenAsync()
        {
            return App.Database.connection.GetAllWithChildrenAsync<T>();
        }
        #endregion
    }
}
