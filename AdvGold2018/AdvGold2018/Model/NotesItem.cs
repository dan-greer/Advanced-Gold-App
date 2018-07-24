using SQLite;

namespace AdvGold2018
{
    public class NotesItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
    }
}
