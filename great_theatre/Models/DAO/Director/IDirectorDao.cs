using System.Collections.Generic;

namespace great_theatre.Models.DAO.Director
{
	public interface IDirectorDao
	{
        void Add(Entities.Director director);
        void Edit(Entities.Director director);
        void Delete(Entities.Director director);
        Entities.Director Lead(int id);
        List<Entities.Director> Load(int skip, int take);
 
	}
}