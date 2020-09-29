using System.Collections.Generic;
using Models;
namespace Data{
    public interface IbananRepo{
        IEnumerable<banan> GetAppbanan();
        banan GetBananByID(int id);
        bool DeletebananByID(int id);
    }
}