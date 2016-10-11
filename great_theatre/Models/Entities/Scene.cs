using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace great_theatre.Models.Entities
{
	public class Scene
	{
		public Scene()
		{
			Tickets= new List<Ticket>();
		}
        public int Id { get; set; }
        [Required(ErrorMessage = "Не корректно введена дата")]
        [Display(Name = "Дата")]
		public DateTime Date { get; set; }

	    [Required(ErrorMessage = "Не корректно введено имя постановки")]
	    [Display(Name = "Постановка")]
	    public Perfomance Perfomance { get; set; }

	    public ICollection<Ticket> Tickets { get; set; }
	    public int PerfomanceId { get; set; }
	}
}