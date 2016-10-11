using System.Collections.Generic;

namespace great_theatre.Models.DAO.Ticket
{
	public interface ITicketDao
	{
        void Add();
        void Edit();
        void Delete();
        Entities.Ticket Lead(int id);
        List<Entities.Ticket> Load(int skip, int take);
	}
}