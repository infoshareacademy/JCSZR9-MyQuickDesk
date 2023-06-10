using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public interface IDeskService
    {
        List<Desk> GetAll();
        Desk GetById(Guid id);
        void Create(Desk desk);
        void Update(Desk desk);
        void Delete(Guid id);

       

    }
}