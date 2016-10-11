using System.Collections.Generic;
using System.Linq;
using great_theatre.Models.DAO.Perfomance;
using great_theatre.Models.DAO.Scene;
using great_theatre.Models.Entities;

namespace great_theatre.Models.Home
{
    public class HomeService : IHomeService
    {
        private readonly ISceneDao _sceneDao;
        private readonly IPerfomanceDao _perfomanceDao;

        public HomeService(ISceneDao sceneDao, IPerfomanceDao perfomanceDao)
        {
            _sceneDao = sceneDao;
            _perfomanceDao = perfomanceDao;
        }

        public List<Search> Search(string name)
        {
            return _sceneDao.Search(name).Select(item => new Search
            {
                Performances = _perfomanceDao.Load(item.PerfomanceId), Scenes = item
            }).ToList();
        }
    }
}