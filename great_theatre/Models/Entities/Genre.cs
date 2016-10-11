using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace great_theatre.Models.Entities
{
	public class Genre
	{
		public Genre()
		{
			Perfomances = new List<Perfomance>();
		}
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
        [Required(ErrorMessage = "Не корректно введен жанр")]
        [Display(Name = "Жанр")]
		public string Name { get; set; }
		public ICollection<Perfomance> Perfomances { get; set; }

	}
}