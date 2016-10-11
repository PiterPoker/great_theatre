using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace great_theatre.Models.DAO.Genre
{
	public class GenreDao : IGenreDao
	{
	    public void Add(Entities.Genre genre)
	    {
            using (var context = new ApplicationDbContext())
            {
                context.Genres.Add(genre);
                context.SaveChanges();
            }
	    }

	    public void Edit(Entities.Genre genre)
	    {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(genre).State = EntityState.Modified;
                context.SaveChanges();
            }
	    }
	    public void Delete(Entities.Genre genre)
	    {
            using (var context = new ApplicationDbContext())
            {
                var deleteItem = context.Genres.FirstOrDefault(g => g.Id == genre.Id);
                if (deleteItem == null)
                    return;
                context.Genres.Remove(deleteItem);
                context.SaveChanges();
            }
	    }

	    public Entities.Genre Lead(int id)
	    {
            Entities.Genre genre;
            using (var context = new ApplicationDbContext())
            {
                genre = context.Genres.FirstOrDefault(g => g.Id == id);
            }
            return genre;
	    }

	    public List<Entities.Genre> Load(int skip, int take)
	    {
            List<Entities.Genre> genre;
            using (var context = new ApplicationDbContext())
            {
                genre = context.Genres.OrderBy(g => g.Name).Skip(skip).Take(take).ToList();
            }
            return genre;
	    }
	}
}