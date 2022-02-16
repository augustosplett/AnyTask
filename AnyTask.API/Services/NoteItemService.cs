using AnyTask.API.Models;

namespace AnyTask.API.Services
{
    public class NoteItemService
    {
        static List<NoteItem> NoteItems { get; }

        static int nextId = 3;

        static NoteItemService()
        {
            NoteItems = new List<NoteItem>
            {
                new NoteItem { Id = 1, NoteContent = "teste nota 1", NoteDate = DateTime.Now },
                new NoteItem { Id = 2, NoteContent = "teste nota 2", NoteDate = DateTime.Now }
            };
 
        }

        public static List<NoteItem> GetAll() => NoteItems;

        public static NoteItem? Get(int id) => NoteItems.FirstOrDefault(p => p.Id == id);

        public static void Add(NoteItem noteItem)
        {
            noteItem.Id = nextId++;
            NoteItems.Add(noteItem);
        }


    }
}
