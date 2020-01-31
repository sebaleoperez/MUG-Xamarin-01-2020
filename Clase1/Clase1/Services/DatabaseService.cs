using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;

namespace Clase1.Services
{
    public class DatabaseService
    {
        SQLiteAsyncConnection conn;

        public DatabaseService()
        {
            var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            conn = new SQLiteAsyncConnection(Path.Combine(basePath, "database.db"));
        }

        public async void SaveAllPeople(List<People> list)
        {
            await conn.CreateTableAsync<People>();

            foreach (People people in list)
            {
                await conn.InsertAsync(people);
            }   
        }

        public async Task<List<People>> GetPeoplesAsync()
        {
            await conn.CreateTableAsync<People>();

            return await conn.Table<People>().ToListAsync();
        }
    }
}
