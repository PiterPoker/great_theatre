using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace great_theatre.Models.Entities
{
	public class Ticket
	{
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Не корректно введено имя покупателя")]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов,",MinimumLength = 3)]
        [Display(Name = "Имя покупателя")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Не корректно введена цена")]
        [Display(Name = "Цена")]
        public int Cost { get; set; }
        public Scene Scene { get; set; }

	}
}