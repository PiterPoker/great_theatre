using System.Collections.Generic;

namespace great_theatre.Models.DAO.Message
{
    public interface IMessageDao
    {
        void Add(Entities.Message message);
        void Delete(Entities.Message message);
        Entities.Message Lead(int id);
        List<Entities.Message> Load();
        List<Entities.Message> Search(string name);
    }
}