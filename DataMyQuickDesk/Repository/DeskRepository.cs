using MyQuickDesk.Entities;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.ApplicationUser;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyQuickDesk.DAL.Entities;
using MyQuickDesk.DAL.DatabaseContext;

namespace MyQuickDesk.DAL.Repository
{
    public interface IDeskService
    {
        List<Desk> GetAll();
        Desk GetById(Guid id);
        void Create(Desk desk);
        void Update(Desk desk);
        void Delete(Guid id);
    }
    public class DeskRepository:IDeskService
    {
        private readonly MyQuickDeskContext _dbContext;
       

        public DeskRepository(MyQuickDeskContext dbContext)
        {
            _dbContext = dbContext;
           
        }        

        public List<Desk> GetAll()
        {
            return _dbContext.Desks.ToList();
        }

        public Desk GetById(Guid id)
        {
            return _dbContext.Desks.FirstOrDefault(d => d.Id == id);
        }

        public void Create(Desk desk)
        {


            _dbContext.Desks.Add(desk);
            _dbContext.SaveChanges();
        }
       
        public void Update(Desk desk)
        {
            _dbContext.Desks.Update(desk);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var desk = _dbContext.Desks.FirstOrDefault(d => d.Id == id);
            if (desk != null)
            {
                _dbContext.Desks.Remove(desk);
                _dbContext.SaveChanges();
            }
        }

    }
}
