using MyQuickDesk.Entities;
using MyQuickDesk.DatabaseContext;

namespace MyQuickDesk.Services
{
    public class DeskService
    {
        private readonly MyQuickDeskContext _dbContext;

        public DeskService(MyQuickDeskContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Desk> GetAll()
        {
            return _dbContext.Desks.ToList();
        }

        public Desk GetById(int id)
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

        public void Delete(int id)
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
