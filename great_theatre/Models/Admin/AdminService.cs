using System.Collections.Generic;
using great_theatre.Models.DAO.Actor;
using great_theatre.Models.DAO.Director;
using great_theatre.Models.DAO.Genre;
using great_theatre.Models.DAO.Message;
using great_theatre.Models.DAO.Perfomance;
using great_theatre.Models.DAO.Scene;
using great_theatre.Models.DAO.Ticket;
using great_theatre.Models.Entities;

namespace great_theatre.Models.Admin
{
    //2 шаг обявить переменную
    public class AdminService : IAdminService
    {
        private readonly IMessageDao _messageDao;
        private readonly IPerfomanceDao _perfomanceDao;
        private readonly ISceneDao _sceneDao;
        private readonly IDirectorDao _directorDao;
        private readonly IActorDao _actorDao;
        private readonly IGenreDao _genreDao;
        private readonly ITicketDao _ticketDao;

        public AdminService(IMessageDao messageDao, IPerfomanceDao perfomanceDao, ISceneDao sceneDao, IDirectorDao directorDao, IActorDao actorDao, IGenreDao genreDao, ITicketDao ticketDao)
        {
            _messageDao = messageDao;
            _perfomanceDao = perfomanceDao;
            _sceneDao = sceneDao;
            _directorDao = directorDao;
            _actorDao = actorDao;
            _genreDao = genreDao;
            _ticketDao = ticketDao;
        }

        public List<Message> LoadMessages()
        {
            var model = _messageDao.Load();
            return model;
        }

        public List<Perfomance> LoadPerfomances()
        {
            var model = _perfomanceDao.Load();
            return model;
        }

        public Perfomance LoadPerfomance(int id)
        {
            var model = _perfomanceDao.Load(id);
            return model;
        }

        public List<Message> Search(string name)
        {
            var model = _messageDao.Search(name);
            return model;
        }
        //3 шаг использовать ее 
        public void AddPerfomance(Perfomance aPerfomance)
        {
            _perfomanceDao.Add(aPerfomance);
        }

        public void AddScene(Scene aScene)
        {
            _sceneDao.Add(aScene);
        }

        public void AddDirector(Director aDirector)
        {
            _directorDao.Add(aDirector);
        }

        public void AddActor(Actor aActor)
        {
            _actorDao.Add(aActor);
        }

        public void AddGenre(Genre aGenre)
        {
            _genreDao.Add(aGenre);
        }
        //до делать добавление билетов.
        public void AddTicket(Ticket aTicket)
        {
            _ticketDao.Add();
        }

        public void EditActor(Actor eActor)
        {
            _actorDao.Edit(eActor);
        }

        public void EditDirector(Director eDirector)
        {
            _directorDao.Edit(eDirector);
        }

        public void EditGenre(Genre eGenre)
        {
            _genreDao.Edit(eGenre);
        }
        public void EditPerfomance(Perfomance ePerfomance)
        {
            _perfomanceDao.Edit(ePerfomance);
        }

        public void EditScene(Scene eScene)
        {
            _sceneDao.Edit(eScene);
        }
        public void DeleteActor(Actor dActor)
        {
            _actorDao.Delete(dActor);
        }

        public void DeleteDirector(Director dDirector)
        {
            _directorDao.Delete(dDirector);
        }

        public void DeleteGenre(Genre dGenre)
        {
            _genreDao.Delete(dGenre);
        }

        public void DeletePerfomance(Perfomance dPerfomance)
        {
            _perfomanceDao.Delete(dPerfomance);
        }

        public void DeleteScene(Scene dScene)
        {
            _sceneDao.Delete(dScene);
        }
    }
}