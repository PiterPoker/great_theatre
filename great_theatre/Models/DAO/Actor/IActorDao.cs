using System.Collections.Generic;

namespace great_theatre.Models.DAO.Actor
{
	public interface IActorDao
	{
		void Add(Entities.Actor actor);
		void Edit(Entities.Actor actor);
		void Delete(Entities.Actor actor);
		Entities.Actor Load(int id);
		List<Entities.Actor> Load(int skip, int take);
		List<Entities.Actor> Load(int id, int skip, int take);
	    int Count();
	}
}