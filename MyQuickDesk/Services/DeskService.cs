using MyQuickDesk.Entities;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.ApplicationUser;

namespace MyQuickDesk.Services
{
    public class DeskService
    {
        private readonly MyQuickDeskContext _dbContext;
        private readonly IUserContext _userContext;

        public DeskService(MyQuickDeskContext dbContext, IUserContext userContext)
        {
            _dbContext = dbContext;
            _userContext = userContext;
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
            desk.CreatedById = _userContext.GetCurrentUser().Id;
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
