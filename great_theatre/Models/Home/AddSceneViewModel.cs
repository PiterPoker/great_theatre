using System.Collections.Generic;
using System.Web.Mvc;

namespace great_theatre.Models.Home
{
    public class AddSceneViewModel
    {
        public AddSceneViewModel()
        {
            Performances = new List<SelectListItem>();
        }

        public List<SelectListItem> Performances { get; set; }  
    }
}