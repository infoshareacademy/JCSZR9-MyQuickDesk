using MyQuickDesk.DAL.Entities;
using MyQuickDesk.DAL.DatabaseContext;
using MyQuickDesk.DAL.ApplicationUser;
using Microsoft.EntityFrameworkCore;


namespace MyQuickDesk.DAL.Repository
{
    public interface IDeskRepository
    {
        List<Desk> GetAll();
        Desk GetById(Guid id);
        void Create(Desk desk);
        void Update(Desk desk);
        void Delete(Guid id);
    }
    public class DeskRepository : IDeskRepository
    {
        private readonly MyQuickDeskContext _dbContext;
        private readonly ApplicationUser.IUserContext _userContext;

        public DeskRepository(MyQuickDeskContext dbContext, ApplicationUser.IUserContext userContext)
        {
            _dbContext = dbContext;
            _userContext = userContext;
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

            var currentUser = _userContext.GetCurrentUser();
            if (currentUser == null || !currentUser.IsAdmin("Admin"))
            {
                return;
            }

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
