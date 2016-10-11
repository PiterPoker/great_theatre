using System.Collections.Generic;

namespace great_theatre.Models.DAO.Genre
{
	public interface IGenreDao
	{
        void Add(Entities.Genre genre);
        void Edit(Entities.Genre genre);
        void Delete(Entities.Genre genre);
        Entities.Genre Lead(int id);
        List<Entities.Genre> Load(int skip, int take);
	}
}