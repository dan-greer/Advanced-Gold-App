using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace AdvGold2018
{
    public class NoteItemDatabase
    {

        readonly SQLiteAsyncConnection database;

        // Creates the initial database for notes
        public NoteItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<NotesItem>().Wait();
        }

        // Gets all of the notes already saved
        public Task<List<NotesItem>> GetItemsAsync()
        {
            return database.Table<NotesItem>().ToListAsync();
        }

        // Gets an individual note
        public Task<NotesItem> GetItemAsync(int id)
        {
            return database.Table<NotesItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        // Saves a note
        public Task<int> SaveItemAsync(NotesItem item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        // Removes a note
        public Task<int> DeleteItemAsync(NotesItem item)
        {
            return database.DeleteAsync(item);
        }
    }
}
