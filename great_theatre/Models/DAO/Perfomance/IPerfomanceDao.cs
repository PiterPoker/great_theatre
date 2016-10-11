using System.Collections.Generic;

namespace great_theatre.Models.DAO.Perfomance
{
	public interface IPerfomanceDao
	{
        void Add(Entities.Perfomance perfomance);
        void Edit(Entities.Perfomance perfomance);
        void Delete(Entities.Perfomance perfomance);
        Entities.Perfomance Load(int id);
        List<Entities.Perfomance> Load(); 
	}
}