using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace great_theatre.Models.DAO.Director
{
	public class DirectorDao : IDirectorDao
	{
	    public void Add(Entities.Director director)
	    {
            using (var context = new ApplicationDbContext())
            {
                context.Directors.Add(director);
                context.SaveChanges();
            }
	    }

	    public void Edit(Entities.Director director)
	    {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(director).State = EntityState.Modified;
                context.SaveChanges();
            }
	    }

	    public void Delete(Entities.Director director)
	    {
            using (var context = new ApplicationDbContext())
            {
                var deleteItem = context.Directors.FirstOrDefault(d => d.Id == director.Id);
                if (deleteItem == null)
                    return;
                context.Directors.Remove(deleteItem);
                context.SaveChanges();
            }
	    }

	    public Entities.Director Lead(int id)
	    {
            Entities.Director director;
            using (var context = new ApplicationDbContext())
            {
                director = context.Directors.FirstOrDefault(a => a.Id == id);
            }
            return director;
	    }

	    public List<Entities.Director> Load(int skip, int take)
	    {
            List<Entities.Director> directors;
            using (var context = new ApplicationDbContext())
            {
                directors = context.Directors.OrderBy(a => a.LastName).Skip(skip).Take(take).ToList();
            }
            return directors;
	    }
	}
}