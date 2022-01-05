using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using HabilidApp.Models;
using System.Threading.Tasks;

namespace HabilidApp.DataBase
{
    public class DataBaseQuery
    {
        readonly SQLiteAsyncConnection _database;

        public DataBaseQuery(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            _database.CreateTableAsync<UserModel>().Wait();

            _database.CreateTableAsync<HabilidadesModel>().Wait();

            _database.CreateTableAsync<ActividadesModel>().Wait();
        }

        #region CRUD
        public Task<int> SaveUserModel(UserModel usermodel)
        {
            if(usermodel.IdUsuario!=0)
            {
                return _database.UpdateAsync(usermodel);
            }
            else
            {
                return _database.InsertAsync(usermodel);
            }
        }

        public Task<int> DeleteModelAsync<T>(T model) where T : new()
        {

            return _database.DeleteAsync(model);

        }
        public Task<int> SaveModel<T>(T model, bool isInsert) where T : new()
        {
            if (isInsert)
            {
                 return _database.InsertAsync(model);
            }
            else
            {
                return _database.UpdateAsync(model);
            }
        }

        public Task<List<UserModel>> GetUserModel()
        {
            return _database.Table<UserModel>().ToListAsync();
        }

        public Task<List<T>> GetTableModel<T>() where T: new()
        {
            return _database.Table<T>().ToListAsync();
        }

        public Task<List<UserModel>> ValidateUserModel(string correo, string clave)
        {
            return _database.QueryAsync<UserModel>("SELECT * FROM UserModel WHERE Correo = '"+correo+"' AND Clave = '"+clave+"' ");
        }

        public Task<List<T>> QueryModel<T>(string query) where T : new()
        {
            return _database.QueryAsync<T>(query);
        }

        public Task<UserModel> GetUserModel(string correo, string clave)
        {
            return _database.Table<UserModel>().Where(i => i.Correo == correo && i.Clave == clave).FirstOrDefaultAsync();
        }

        public Task<List<HabilidadesModel>> GetHabilidadesModel(bool terminado)
        {
            return _database.Table<HabilidadesModel>().Where(i => i.Terminado == terminado).ToListAsync();
        }

        public Task<List<ActividadesModel>> GetActividadesModel(int idHabilidad)
        {
            return _database.Table<ActividadesModel>().Where(i => i.idHabilidad == idHabilidad).ToListAsync();
        }


        #endregion
    }
}
