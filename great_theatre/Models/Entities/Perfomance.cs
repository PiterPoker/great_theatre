using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace great_theatre.Models.Entities
{
	public class Perfomance
	{
		public Perfomance()
		{
            Genres = new List<Genre>();
            Acters = new List<Actor>();
            Scenes = new List<Scene>();
		}
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Не корректно введено имя постановки")]
        [Display(Name = "Постановка")]
        public string Name { get; set; }
        public  ICollection<Genre> Genres { get; set; }
		public  ICollection<Actor> Acters { get; set; }
		public  ICollection<Scene> Scenes { get; set; }
	}
}