using System.Reflection.Metadata.Ecma335;
using ToDo.Domain.Extensions;

namespace ToDo.Domain.Entities
{
    public class Item
    {
        /// <summary>
        /// Put it after
        /// </summary>
        public Item()
        {

        }
        public Item(string task)
        {
            Id = Guid.NewGuid();
            Done = false;
            Description = task;
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public bool Done { get; private set; }
        public DateTime CreatedAt { get; private set; }

        //public string CreatedAtToString{ 
        //    get { 
        //        return CreatedAt.ToSQLDate(); 
        //    } 
        //}

        public void MarkAsDone() => Done = true;
        public void MarkAsUndone() => Done = true;

        public void SetID(Guid id)
        {
            Id = id;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public void SetDone(bool done)
        {
            Done = done;
        }
    }
}
