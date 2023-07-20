
using Microsoft.EntityFrameworkCore;
using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;


namespace MyQuickDesk.Services
{
    public interface IReservationService
    {
        Task<IEnumerable<Reservation>> GetAllAsync();
        Task <Reservation> GetByIdAsync(Guid id);
        Task CreateAsync(Reservation reservation);
        Task <bool> UpdateAsync(Guid Id, Reservation model);
        Task DeleteAsync(Guid id);
        Task <bool> IsReservationValidAsync(Reservation reservation);

    }
    public class ReservationService : IReservationService
    {
        private readonly MyQuickDeskContext _dbContext;
        private readonly IUserContext _userContext;

        public ReservationService(MyQuickDeskContext dbContext, IUserContext userContext)
        {
            _dbContext = dbContext;
            _userContext = userContext;
        }
        public async Task <IEnumerable<Reservation>> GetAllAsync()
        {
            return await _dbContext.Reservations
                .Include(r => r.Space)
                .Include(r => r.User) 
                .ToListAsync();
        }


        public async Task <Reservation> GetByIdAsync(Guid id)
        {
            return  await _dbContext.Reservations.Include(r => r.Space).Include(r => r.User).FirstOrDefaultAsync(r => r.Id == id);
        }


        public async Task CreateAsync(Reservation reservation)
        {
            var currentUser = _userContext.GetCurrentUser();
            var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == currentUser.Id);

            if (existingUser != null)
            {
                reservation.User = existingUser;
            }
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
        }
        public async Task <bool> IsReservationValidAsync(Reservation reservation)
        {
            var existingReservation =await _dbContext.Reservations.FirstOrDefaultAsync(r =>
                r.Id != reservation.Id &&
                r.Space != null && reservation.Space != null && 
                r.Space.Id == reservation.Space.Id &&
                (
                    (reservation.StartTime >= r.StartTime && reservation.StartTime < r.EndTime) ||
                    (reservation.EndTime > r.StartTime && reservation.EndTime <= r.StartTime) ||
                    (reservation.StartTime <= r.StartTime && reservation.EndTime >= r.EndTime)
                )
            );

            return existingReservation == null;
        }




        public async Task <bool> UpdateAsync(Guid id, Reservation model)
        {
            var existingReservation =await _dbContext.Reservations.FirstOrDefaultAsync(r => r.Id == id);

            if (existingReservation == null)
            {
                return false;
            }

            existingReservation.StartTime = model.StartTime;
            existingReservation.EndTime = model.EndTime;
            existingReservation.Space = model.Space;
            if (await IsReservationValidAsync(existingReservation))
            {
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        public async Task DeleteAsync(Guid id)
        {
            var reservations =await _dbContext.Reservations.FirstOrDefaultAsync(r => r.Id == id);
            if (reservations != null)
            {
                _dbContext.Reservations.Remove(reservations);
                _dbContext.SaveChanges();
            }
        }

    }
}