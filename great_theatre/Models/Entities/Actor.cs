using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace great_theatre.Models.Entities
{
	public class Actor
	{
		 public Actor()
		 {
             Perfomances = new List<Perfomance>();
		 }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
        [Required(ErrorMessage = "Не корректно введена фамилия")]
        [Display(Name = "Фамилия")]
		public string FirstName { get; set; }
        [Required(ErrorMessage = "Не корректно введено имя")]
        [Display(Name = "Имя")]
        public string LastName { get; set; }
        public  ICollection<Perfomance> Perfomances { get; set; }
	}
}