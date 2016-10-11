using System;
using System.Globalization;
using System.Web.Mvc;
using great_theatre.Models.Admin;
using great_theatre.Models.Entities;
using great_theatre.Models.Home;

namespace great_theatre.Controllers
{
    //
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Messages()
        {
            var model = _adminService.LoadMessages();
            return View(model);
        }

        public ActionResult Compose()
        {
            return View();
        }

        public ActionResult Search(string name)
        {
            var model = _adminService.Search(name);
            return View(model);
        }

        [HttpGet]
        public ActionResult AddPerfomence()
        {
            return View();
        }

        //4 шаг создание методов
        /*5 шаг добавления представления*/

        public ActionResult AddPerfomence(Perfomance addPerf)
        {
            if (ModelState.IsValid)
            {
                _adminService.AddPerfomance(addPerf);
                return RedirectToAction("AddPerfomence");
            }
            return View(addPerf);
        }

        [HttpGet]
        public ActionResult AddScene()
        {
            var model = new AddSceneViewModel();
            model.Performances.Add(new SelectListItem
            {
                Disabled = true,
                Selected = true,
                Text = "Выберите постановку",
                Value = ""
            });
            foreach (var item in _adminService.LoadPerfomances())
            {
                model.Performances.Add(new SelectListItem
                {
                    Disabled = false,
                    Selected = false,
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult AddScene(string date, string performanceId)
        {
            var scene = new Scene
            {
                Date = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                Perfomance = _adminService.LoadPerfomance(Convert.ToInt32(performanceId))
            };

            if (!ModelState.IsValid)
            {
                var model = new AddSceneViewModel();
                model.Performances.Add(new SelectListItem
                {
                    Disabled = true,
                    Selected = true,
                    Text = "Выберлжлфаовжа",
                    Value = ""
                });
                foreach (var item in _adminService.LoadPerfomances())
                {
                    model.Performances.Add(new SelectListItem
                    {
                        Disabled = false,
                        Selected = false,
                        Text = item.Name,
                        Value = item.Id.ToString()
                    });
                }
                return View(model);
            }
            _adminService.AddScene(scene);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddDirector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDirector(Director addDirector)
        {
            if (ModelState.IsValid)
            {
                _adminService.AddDirector(addDirector);
                return RedirectToAction("AddDirector");
            }
            return View(addDirector);
        }

        [HttpGet]
        public ActionResult AddActor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddActor(Actor addActor)
        {
            if (ModelState.IsValid)
            {
                _adminService.AddActor(addActor);
                return RedirectToAction("AddActor");
            }
            return View(addActor);
        }

        [HttpGet]
        public ActionResult AddGenre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGenre(Genre addGenre)
        {
            if (ModelState.IsValid)
            {
                _adminService.AddGenre(addGenre);
                return RedirectToAction("AddGenre");
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditActor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditActor(Actor editActor)
        {
            if (ModelState.IsValid)
            {
                _adminService.EditActor(editActor);
                return RedirectToAction("EditActor");
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditDirector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditDirector(Director editDirector)
        {
            if (ModelState.IsValid)
            {
                _adminService.EditDirector(editDirector);
                return RedirectToAction("EditDirector");
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditGenre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditGenre(Genre editGenre)
        {
            if (ModelState.IsValid)
            {
                _adminService.EditGenre(editGenre);
                return RedirectToAction("EditGenre");
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditPerfomance()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditPerfomance(Perfomance editPerfomance)
        {
            if (ModelState.IsValid)
            {
                _adminService.EditPerfomance(editPerfomance);
                return RedirectToAction("EditPerfomance");
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditScene()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditScene(Scene editScene)
        {
            if (ModelState.IsValid)
            {
                _adminService.EditScene(editScene);
                return RedirectToAction("EditScene");
            }
            return View();
        }

        [HttpGet]
        public ActionResult DeleteActor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteActor(Actor deleteActor)
        {
            if (ModelState.IsValid)
            {
                _adminService.DeleteActor(deleteActor);
                return RedirectToAction("DeleteActor");
            }
            return View();
        }

        [HttpGet]
        public ActionResult DeleteDirector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteDirector(Director deleteDirector)
        {
            if (ModelState.IsValid)
            {
                _adminService.DeleteDirector(deleteDirector);
                return RedirectToAction("DeleteDirector");
            }
            return View();
        }

        [HttpGet]
        public ActionResult DeleteGenre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteGenre(Genre deleteGenre)
        {
            if (ModelState.IsValid)
            {
                _adminService.DeleteGenre(deleteGenre);
                return RedirectToAction("DeleteGenre");
            }
            return View();
        }

        [HttpGet]
        public ActionResult DeletePerfomance()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeletePerfomance(Perfomance deletePerfomance)
        {
            if (ModelState.IsValid)
            {
                _adminService.DeletePerfomance(deletePerfomance);
                return RedirectToAction("DeletePerfomance");
            }
            return View();
        }

        [HttpGet]
        public ActionResult DeleteScene()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteScene(Scene deleteScene)
        {
            if (ModelState.IsValid)
            {
                _adminService.DeleteScene(deleteScene);
                return RedirectToAction("DeleteScene");
            }
            return View();
        }
    }
}