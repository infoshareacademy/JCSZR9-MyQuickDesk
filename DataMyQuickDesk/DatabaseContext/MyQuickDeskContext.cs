using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyQuickDesk.DAL.Entities;

namespace MyQuickDesk.DAL.DatabaseContext
{
    public class MyQuickDeskContext : IdentityDbContext
    {
        public MyQuickDeskContext(DbContextOptions<MyQuickDeskContext> options) : base(options) { }

        public DbSet<Space> Spaces { get; set; }


        public DbSet<Desk> Desks { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set;}


        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Reservation>(mb =>
            {
                mb.HasOne(r => r.Desk).
                    WithMany(d => d.Reservations).
                    HasForeignKey(r => r.DeskId);
                mb.HasOne(r => r.Room).
                    WithMany(rm => rm.Reservations).
                    HasForeignKey(r => r.RoomId);
                mb.HasOne(r => r.ParkingSpot).
                    WithMany(ps => ps.Reservations).
                    HasForeignKey(r => r.ParkingSpotId);

                mb.HasOne(r => r.User).
                    WithMany(u => u.Reservations).
                    HasForeignKey(r => r.UserId);

            });



            modelBuilder.Entity<Room>().HasData
            (
               new Room
               {
                   Id = Guid.NewGuid(),
                   Name = "Mariacka",
                   MaxCapacity = 8,
                   IsAvaiable = true

               },
               new Room
               {
                   Id = Guid.NewGuid(),
                   Name = "Neptun",
                   MaxCapacity = 10,
                   IsAvaiable = true
               },
               new Room
               {
                   Id = Guid.NewGuid(),
                   Name = "Polityczna",
                   MaxCapacity = 12,
                   IsAvaiable = true
               }

            );
            modelBuilder.Entity<Desk>().HasData
            (
                new Desk
                {
                    Id = Guid.NewGuid(),
                    Name = "Biurko A1",
                    IsAvaiable = true
                },
                new Desk
                {
                    Id = Guid.NewGuid(),
                    Name = "Biurko A2",
                    IsAvaiable = true
                },
                new Desk
                {
                    Id = Guid.NewGuid(),
                    Name = "Biurko A3",
                    IsAvaiable = true
                },
                new Desk
                {
                    Id = Guid.NewGuid(),
                    Name = "Biurko B1",
                    IsAvaiable = true
                },
                new Desk
                {
                    Id = Guid.NewGuid(),
                    Name = "Biurko B2",
                    IsAvaiable = true
                }
            );
            modelBuilder.Entity<ParkingSpot>().HasData
            (
                new ParkingSpot
                {
                    Id = Guid.NewGuid(),
                    Name = "P1A1",
                    HandicappedSpot = true,
                    Charger = true
                },
                new ParkingSpot
                {
                    Id = Guid.NewGuid(),
                    Name = "P1A2",
                    HandicappedSpot = true,
                    Charger = true
                },
                new ParkingSpot
                {
                    Id = Guid.NewGuid(),
                    Name = "P1A3",
                    HandicappedSpot = true,
                    Charger = true
                },
                new ParkingSpot
                {
                    Id = Guid.NewGuid(),
                    Name = "P1B1",
                    HandicappedSpot = true,
                    Charger = true
                }
            );

        }


    }
}
