using System.Collections.Generic;

namespace great_theatre.Models.Home
{
    public interface IHomeService
    {
        List<Search> Search(string name); 
        
    }
}