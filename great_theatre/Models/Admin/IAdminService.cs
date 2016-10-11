using System.Collections.Generic;
using great_theatre.Models.Entities;
using great_theatre.Models.Home;

namespace great_theatre.Models.Admin
{
    public interface IAdminService
    {   //1 шаг объявления в интерфейсе методов
        List<Message> LoadMessages();
        List<Perfomance> LoadPerfomances();
        Perfomance LoadPerfomance(int id);
        List<Message> Search(string name);
        void AddPerfomance(Perfomance aPerfomance);
        void AddScene(Scene aScene);
        void AddDirector(Director aDirector);
        void AddActor(Actor aActor);
        void AddGenre(Genre aGenre);
        void AddTicket(Ticket aTicket);
        void EditActor(Actor eActor);
        void EditDirector(Director eDirector);
        void EditGenre(Genre eGenre);
        void EditPerfomance(Perfomance ePerfomance);
        void EditScene(Scene eScene);
        void DeleteActor(Actor dActor);
        void DeleteDirector(Director dDirector);
        void DeleteGenre(Genre dGenre);
        void DeletePerfomance(Perfomance dPerfomance);
        void DeleteScene(Scene dScene);

    }
}