using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace great_theatre.Models.DAO.Perfomance
{
	public class PerfomanceDao : IPerfomanceDao
	{
	    public void Add(Entities.Perfomance perfomance)
	    {
            using (var context = new ApplicationDbContext())
            {
                context.Perfomances.Add(perfomance);
                context.SaveChanges();
            }
	    }

	    public void Edit(Entities.Perfomance perfomance)
	    {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(perfomance).State = EntityState.Modified;
                context.SaveChanges();
            }
	    }

	    public void Delete(Entities.Perfomance perfomance)
	    {
            using (var context = new ApplicationDbContext())
            {
                var deleteItem = context.Perfomances.FirstOrDefault(p => p.Id == perfomance.Id);
                if (deleteItem == null)
                    return;
                context.Perfomances.Remove(deleteItem);
                context.SaveChanges();
            }
	    }

	    public Entities.Perfomance Load(int id)
	    {
            Entities.Perfomance perfomance;
            using (var context = new ApplicationDbContext())
            {
                perfomance = context.Perfomances.FirstOrDefault(p => p.Id == id);
            }
            return perfomance;
	    }

	    public List<Entities.Perfomance> Load()
	    {
            List<Entities.Perfomance> perfomances;
            using (var context = new ApplicationDbContext())
            {
                perfomances = context.Perfomances.OrderBy(p => p.Name).ToList();
            }
            return perfomances;
	    }
	}
}