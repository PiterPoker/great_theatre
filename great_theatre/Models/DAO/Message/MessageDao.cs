using System.Collections.Generic;
using System.Linq;

namespace great_theatre.Models.DAO.Message
{
    public class MessageDao : IMessageDao
    {
        public void Add(Entities.Message message)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Messages.Add(message);
                context.SaveChanges();
            }
        }

        public void Delete(Entities.Message message)
        {
            using (var context = new ApplicationDbContext())
            {
                var deleteItem = context.Messages.FirstOrDefault(m => m.Id == message.Id);
                if (deleteItem == null)
                    return;
                context.Messages.Remove(deleteItem);
                context.SaveChanges();
            }
        }

        public Entities.Message Lead(int id)
        {
            Entities.Message message;
            using (var context = new ApplicationDbContext())
            {
                message = context.Messages.FirstOrDefault(m => m.Id == id);
            }
            return message;
        }

        public List<Entities.Message> Load()
        {
            List<Entities.Message> messages;
            using (var context = new ApplicationDbContext())
            {
                messages = context.Messages.OrderBy(m => m.Time).ToList();
            }
            return messages;
        }
        public List<Entities.Message> Search(string name)
        {
            List<Entities.Message> messages;
            using (var context = new ApplicationDbContext())
            {
                messages = context.Messages.Where(m => m.Sender.Contains(name))
                    .OrderByDescending(m => m.Time).ToList();
            }
            return messages;
        }
    }
}