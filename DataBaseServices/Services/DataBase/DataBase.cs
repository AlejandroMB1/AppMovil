using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

//Clase singleTon de lectura Base de datos 
namespace DataBaseServices.Services.DataBase
{
    public class DataBase
    {
        public readonly SQLiteAsyncConnection connection;
        public DataBase(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);
        }
    }
}
